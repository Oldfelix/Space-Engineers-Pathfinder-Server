﻿using Sandbox.Common.ObjectBuilders;
using Sandbox.Game.Entities;
using Sandbox.Game.Entities.Cube;
using Sandbox.Game.Gui;
using Sandbox.Graphics.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VRageMath;
using VRage;
using Sandbox.Engine.Utils;
using Sandbox.Definitions;
using Sandbox.Engine.Models;
using VRage.Game;

namespace Sandbox.Game.Screens.DebugScreens
{
#if !XB1

    [MyDebugScreen("Game", "Cube Blocks")]
    class MyGuiScreenDebugCubeBlocks : MyGuiScreenDebugBase
    {
        MyGuiControlCombobox m_combo;
        MyGuiControlButton m_button;
        MyGuiControlSlider m_dummyDrawDistanceSlider;

        public override string GetFriendlyName()
        {
            return "MyGuiScreenDebugCubeBlocks";
        }
        public MyGuiScreenDebugCubeBlocks()
        {
            RecreateControls(true);
        }

        public override void RecreateControls(bool constructor)
        {
            base.RecreateControls(constructor);
            AddCaption("Cube blocks", Color.Yellow.ToVector4());
            m_combo = AddCombo();
            m_combo.Position = new Vector2(-0.15f, -0.35f);
            Dictionary<long, int> dict = new Dictionary<long, int>();
            Dictionary<long, StringBuilder> names = new Dictionary<long, StringBuilder>();
            foreach (var entity in MyEntities.GetEntities())
            {
                if (entity is MyCubeGrid)
                {
                    var grid = entity as MyCubeGrid;
                    foreach (var block in grid.GetBlocks())
                    {
                        long defId = block.BlockDefinition.Id.GetHashCode();
                        if (!dict.ContainsKey(defId))
                            dict.Add(defId, 0);

                        dict[defId]++;

                        string cubesize = "";
                        switch(block.BlockDefinition.CubeSize)
                        {
                            case MyCubeSize.Large: cubesize = "Large"; break;
                            case MyCubeSize.Small: cubesize = "Small"; break;
                        }

                        StringBuilder blockName = new StringBuilder().Append("[").Append(cubesize).Append("] ").Append(block.BlockDefinition.DisplayNameText);

                        if (!names.ContainsKey(defId))
                            names.Add(defId, blockName);
                    }
                }
            }

            int qt;
            StringBuilder name;
            foreach (var key in names.Keys) //could be dict.Keys too
            {
                if (names.TryGetValue(key, out name) && dict.TryGetValue(key, out qt))
                    m_combo.AddItem(key, name.Append(": ").Append(qt));
            }

            m_combo.SortItemsByValueText();
            if(m_combo.GetItemsCount() > 0)
                m_combo.SelectItemByIndex(0);
            m_button = AddButton(new StringBuilder("Remove All"), onClick_RemoveAllBlocks);
            m_button.VisualStyle = MyGuiControlButtonStyleEnum.Default;
            m_button.Position = new Vector2(0.0f, -0.25f);

            m_currentPosition = -m_size.Value / 2.0f + new Vector2(0.02f, 0.35f);

            AddCheckBox("Enable use object highlight", null, MemberHelper.GetMember(() => MyFakes.ENABLE_USE_OBJECT_HIGHLIGHT));
            AddCheckBox("Show grids decay", null, MemberHelper.GetMember(() => MyDebugDrawSettings.DEBUG_DRAW_GRIDS_DECAY));
            m_dummyDrawDistanceSlider = AddSlider("Dummies draw distance", MyDebugDrawSettings.DEBUG_DRAW_MODEL_DUMMIES_DISTANCE, 0, 100, null);
            m_dummyDrawDistanceSlider.ValueChanged = DummyDrawDistanceSliderChanged;

            m_currentPosition += new Vector2(0.00f, 0.21f);

            AddCheckBox("Debug draw all mount points", MyDebugDrawSettings.DEBUG_DRAW_MOUNT_POINTS_ALL, onClick_DebugDrawMountPointsAll);
            AddCheckBox("Debug draw mount points", MyDebugDrawSettings.DEBUG_DRAW_MOUNT_POINTS, onClick_DebugDrawMountPoints);
            AddCheckBox("Forward", null, MemberHelper.GetMember(() => MyDebugDrawSettings.DEBUG_DRAW_MOUNT_POINTS_AXIS0));
            AddCheckBox("Backward", null, MemberHelper.GetMember(() => MyDebugDrawSettings.DEBUG_DRAW_MOUNT_POINTS_AXIS1));
            AddCheckBox("Left", null, MemberHelper.GetMember(() => MyDebugDrawSettings.DEBUG_DRAW_MOUNT_POINTS_AXIS2));
            AddCheckBox("Right", null, MemberHelper.GetMember(() => MyDebugDrawSettings.DEBUG_DRAW_MOUNT_POINTS_AXIS3));
            AddCheckBox("Up", null, MemberHelper.GetMember(() => MyDebugDrawSettings.DEBUG_DRAW_MOUNT_POINTS_AXIS4));
            AddCheckBox("Down", null, MemberHelper.GetMember(() => MyDebugDrawSettings.DEBUG_DRAW_MOUNT_POINTS_AXIS5));
            AddCheckBox("Draw autogenerated", null, MemberHelper.GetMember(() => MyDebugDrawSettings.DEBUG_DRAW_MOUNT_POINTS_AUTOGENERATE));
            AddCheckBox("CubeBlock Integrity", null, MemberHelper.GetMember(() => MyDebugDrawSettings.DEBUG_DRAW_BLOCK_INTEGRITY));

            m_button = AddButton(new StringBuilder("Resave mountpoints"), onClick_Save);
            m_button.VisualStyle = MyGuiControlButtonStyleEnum.Default;

        }

        void DummyDrawDistanceSliderChanged(MyGuiControlSlider slider)
        {
            MyDebugDrawSettings.DEBUG_DRAW_MODEL_DUMMIES_DISTANCE = slider.Value;
        }

        void onClick_DebugDrawMountPointsAll(MyGuiControlCheckbox obj)
        {
            MyDebugDrawSettings.DEBUG_DRAW_MOUNT_POINTS_ALL = obj.IsChecked;            
        }

        void onClick_RemoveAllBlocks(MyGuiControlButton sender)
        {
            var key = m_combo.GetSelectedKey();
            m_button.Text = "Removing...";
            m_button.Enabled = false; 
            List<MySlimBlock> mycubelist = new List<MySlimBlock>();
            foreach (var entity in MyEntities.GetEntities())
            {
                if (entity is MyCubeGrid)
                {
                    mycubelist.Clear();
                    var grid = entity as MyCubeGrid;
                    foreach (var block in grid.GetBlocks())
                    {
                        if (block.BlockDefinition.Id.GetHashCode() == key)
                            mycubelist.Add(block);
                    }

                    foreach(var block in mycubelist)
                        grid.RemoveBlock(block);
                }
            }
            m_button.Text = "Remove All";
            m_button.Enabled = true;
            RecreateControls(false);
        }


        void onClick_RecalculateMountPoints(MyGuiControlButton sender)
        {
        }

        void onClick_DebugDrawMountPoints(MyGuiControlCheckbox sender)
        {
            MyDebugDrawSettings.DEBUG_DRAW_MOUNT_POINTS = sender.IsChecked;//!MyDebugDrawSettings.DEBUG_DRAW_MOUNT_POINTS;
            //MyDebugDrawSettings.ENABLE_DEBUG_DRAW = MyDebugDrawSettings.DEBUG_DRAW_MOUNT_POINTS;
        }

        void onClick_Save(MyGuiControlButton sender)
        {
            foreach (var def in MyDefinitionManager.Static.GetAllDefinitions())
            {
                MyCubeBlockDefinition cubeDef = def as MyCubeBlockDefinition;
                if (cubeDef != null)
                {
                    if (!string.IsNullOrEmpty(cubeDef.Model))
                    {
                        var model = VRage.Game.Models.MyModels.GetModel(cubeDef.Model);
                        var newMountpoints = MyCubeBuilder.AutogenerateMountpoints(model, MyDefinitionManager.Static.GetCubeSize(cubeDef.CubeSize));
                        cubeDef.MountPoints = newMountpoints.ToArray();
                    }
                }
            }

            MyDefinitionManager.Static.Save("CubeBlocks_*.*");
        }
    }

#endif
}
