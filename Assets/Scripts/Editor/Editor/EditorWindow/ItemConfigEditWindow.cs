// // ****************************************************
// //     文件：ItemConfigEditWindow.cs
// //     作者：积极向上小木木
// //     邮箱：positivemumu@126.com
// //     日期：#CreateTime#
// //     功能：
// // *****************************************************
//
// using System.Collections;
// using System.Collections.Generic;
// using System.Linq;
// using Sirenix.OdinInspector.Editor;
// using Sirenix.Utilities;
// using Sirenix.Utilities.Editor;
// using UGUIFramework;
// using UnityEditor;
// using UnityEngine;
//
// public class ItemConfigEditWindow : OdinMenuEditorWindow
// {
//     
//     public static void OpenWindow()
//     {
//         ItemConfigEditWindow windowConfigEditWindow = GetWindow<ItemConfigEditWindow>("WindowConfig EditWindow");
//         windowConfigEditWindow.position = GUIHelper.GetEditorWindowRect().AlignCenter(800, 500);
//         windowConfigEditWindow.autoRepaintOnSceneChange = true;
//         windowConfigEditWindow.Show();
//     }
//
//     protected override OdinMenuTree BuildMenuTree()
//     {
//         var tree = new OdinMenuTree(true);
//         tree.AddAllAssetsAtPath("", "Assets/Game Data/Items", typeof(BaseItem), true);
//         
//         tree.EnumerateTree().AddIcons<BaseItem>(x => x.itemIcon);
//         return tree;
//     }
//     protected override void OnBeginDrawEditors()
//     {
//         var selected = this.MenuTree.Selection.FirstOrDefault();
//         var toolbarHeight = this.MenuTree.Config.SearchToolbarHeight;
//
//         // Draws a toolbar with the name of the currently selected menu item.
//         SirenixEditorGUI.BeginHorizontalToolbar(toolbarHeight);
//         {
//             if (selected != null)
//             {
//                 GUILayout.Label(selected.Name);
//             }
//
//             if (SirenixEditorGUI.ToolbarButton(new GUIContent("Create Item")))
//             {
//                 ScriptableObjectCreator.ShowDialog<BaseItem>("Assets/Game Data/Items", obj =>
//                 {
//                     
//                     base.TrySelectMenuItemWithObject(obj); // Selects the newly created item in the editor
//                 });
//             }
//             
//         }
//         SirenixEditorGUI.EndHorizontalToolbar();
//     }
// }
