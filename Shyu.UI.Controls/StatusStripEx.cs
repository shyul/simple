﻿using Shyu.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shyu.UI.Controls
{
    [System.ComponentModel.DesignerCategory("code")]
    public class StatusStripEx : StatusStrip
    {
        public StatusStripEx()
        {
            DoubleBuffered = true;
            Renderer = new OsianoStatusStripRenderer();
        }
    }
    public class OsianoStatusStripRenderer : ToolStripProfessionalRenderer
    {
        public OsianoStatusStripRenderer() { RoundedEdges = false; }
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkOrange), e.AffectedBounds);
        }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
        }
    }
}
