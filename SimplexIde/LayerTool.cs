﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Docking;
using Microsoft.Xna.Framework.Input;
using SimplexCore;
using MessageBox = System.Windows.Forms.MessageBox;

namespace SimplexIde
{
    public partial class LayerTool : DarkToolWindow
    {
        public DarkTreeView dtv = null;
        public DarkTreeNode selectedNode = null;
        public DrawTest f = null;

        public LayerTool(DrawTest f)
        {         
            InitializeComponent();

            dtv = darkTreeView1;

            DarkTreeNode dtn = new DarkTreeNode("Layers");
            dtn.Icon = (Bitmap)Properties.Resources.ResourceManager.GetObject("Folder_16x");
            dtn.Tag = "folder";
            darkTreeView1.Nodes.Add(dtn);
            f.lt = this;
            this.f = f;
        }

        private void LayerTool_Load(object sender, EventArgs e)
        {

        }

        private void darkTreeView1_Click(object sender, EventArgs e)
        {

        }

        private void darkTreeView1_SelectedNodesChanged(object sender, EventArgs e)
        {
            if (darkTreeView1.SelectedNodes.Count > 0)
            {
                DarkTreeNode dtn = darkTreeView1.SelectedNodes[0];
                if (dtn.Tag != null && (string) dtn?.Tag != "folder")
                {
                    f.selectedLayer = f.roomLayers.FirstOrDefault(x => x.Name == dtn.Text);
                }
            }
        }

        void realSelected(MouseEventArgs e)
        {
            if (darkTreeView1.SelectedNodes.Count > 0 && e.Button == MouseButtons.Right)
            {
                DarkTreeNode dtn = darkTreeView1.SelectedNodes[0];

                if (dtn.Tag != null && (string)dtn?.Tag != "folder")
                {
                    darkContextMenu1.Show(Cursor.Position);
                    selectedNode = dtn;
                }
            }
        }

        private void darkContextMenu1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            darkTreeView1.SelectedNodes.Clear();
        }

        private void darkTreeView1_MouseClick(object sender, MouseEventArgs e)
        {
            realSelected(e);
        }

        private void darkContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // toggle layer visibility
           // if (f.roomLayers.Count > 0)
          // MessageBox.Show(f.roomLayers.Count.ToString());
            {
                RoomLayer rl = f.roomLayers.FirstOrDefault(x => x.Name == selectedNode.Text);
                rl.Visible = !rl.Visible;

                if (!rl.Visible)
                {
                    selectedNode.Icon = Properties.Resources.Visible_16xSM;
                }
                else
                {
                    if (rl.LayerType == RoomLayer.LayerTypes.typeObject)
                    {
                        selectedNode.Icon =
                            (System.Drawing.Bitmap) Properties.Resources.ResourceManager.GetObject("WorldLocal_16x");
                    }
                    else if (rl.LayerType == RoomLayer.LayerTypes.typeAsset)
                    {
                        selectedNode.Icon =
                            (System.Drawing.Bitmap) Properties.Resources.ResourceManager.GetObject("Image_16x");
                    }
                    else
                    {
                        selectedNode.Icon =
                            (System.Drawing.Bitmap) Properties.Resources.ResourceManager.GetObject("MapLineLayer_16x");
                    }
                }

                dtv.Invalidate();
            }
        }
    }
}