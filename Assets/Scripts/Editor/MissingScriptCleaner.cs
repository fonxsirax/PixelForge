using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PixelForge.EditorTools
{
    /// <summary>
    /// Remove componentes MonoBehaviour cujo script nao existe mais. Necessario depois de
    /// apagar os scripts de gameplay do PixelWorld: 311 prefabs e a cena World referenciavam
    /// EnemyBehaviour, TreeFader, BuildingFader e afins, e essas entradas ficam penduradas.
    /// </summary>
    public static class MissingScriptCleaner
    {
        [MenuItem("PixelForge/Limpar scripts ausentes/Contar (nao modifica nada)")]
        public static void Count() => Run(dryRun: true);

        [MenuItem("PixelForge/Limpar scripts ausentes/Remover de prefabs e cenas")]
        public static void Clean()
        {
            bool ok = EditorUtility.DisplayDialog(
                "Remover scripts ausentes",
                "Isso vai reescrever prefabs e cenas removendo componentes com script ausente.\n\n" +
                "Nao pode ser desfeito. Continuar?",
                "Remover", "Cancelar");
            if (ok) Run(dryRun: false);
        }

        private static void Run(bool dryRun)
        {
            var report = new StringBuilder();
            int prefabsHit = 0, componentsRemoved = 0;

            var prefabGuids = AssetDatabase.FindAssets("t:Prefab");
            try
            {
                for (int i = 0; i < prefabGuids.Length; i++)
                {
                    string path = AssetDatabase.GUIDToAssetPath(prefabGuids[i]);
                    if (EditorUtility.DisplayCancelableProgressBar(
                            "Varrendo prefabs", path, (float)i / prefabGuids.Length))
                        break;

                    // LoadPrefabContents abre o prefab isolado, sem instanciar na cena.
                    var root = PrefabUtility.LoadPrefabContents(path);
                    try
                    {
                        int n = RemoveInHierarchy(root, dryRun);
                        if (n > 0)
                        {
                            prefabsHit++;
                            componentsRemoved += n;
                            report.AppendLine($"  {n,3}x  {path}");
                            if (!dryRun) PrefabUtility.SaveAsPrefabAsset(root, path);
                        }
                    }
                    finally
                    {
                        PrefabUtility.UnloadPrefabContents(root);
                    }
                }
            }
            finally
            {
                EditorUtility.ClearProgressBar();
            }

            int scenesHit = 0;
            foreach (var sceneGuid in AssetDatabase.FindAssets("t:Scene"))
            {
                string path = AssetDatabase.GUIDToAssetPath(sceneGuid);
                if (path.StartsWith("Packages/")) continue;

                Scene scene = EditorSceneManager.OpenScene(path, OpenSceneMode.Single);
                int n = 0;
                foreach (var go in scene.GetRootGameObjects())
                    n += RemoveInHierarchy(go, dryRun);

                if (n > 0)
                {
                    scenesHit++;
                    componentsRemoved += n;
                    report.AppendLine($"  {n,3}x  {path}");
                    if (!dryRun) EditorSceneManager.SaveScene(scene);
                }
            }

            if (!dryRun) AssetDatabase.SaveAssets();

            string head = dryRun ? "[simulacao] encontrados" : "removidos";
            Debug.Log($"MissingScriptCleaner: {head} {componentsRemoved} componentes ausentes " +
                      $"em {prefabsHit} prefabs e {scenesHit} cenas.\n{report}");
        }

        private static int RemoveInHierarchy(GameObject root, bool dryRun)
        {
            int total = 0;
            var stack = new Stack<Transform>();
            stack.Push(root.transform);

            while (stack.Count > 0)
            {
                var t = stack.Pop();
                int missing = GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(t.gameObject);
                if (missing > 0)
                {
                    total += missing;
                    if (!dryRun)
                        GameObjectUtility.RemoveMonoBehavioursWithMissingScript(t.gameObject);
                }
                for (int i = 0; i < t.childCount; i++) stack.Push(t.GetChild(i));
            }
            return total;
        }
    }
}
