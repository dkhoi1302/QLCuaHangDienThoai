using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomButton
{
    public class Custom_Button : Button
    {
        // === CÁC PROPERTY CŨ (để Designer nhận diện) ===
        private int borderSize = 0;
        private Color backgroundColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;

        [Category("Custom Props")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        [Category("Custom Props")]
        public Color BackgroundColor
        {
            get => backgroundColor;
            set { backgroundColor = value; Invalidate(); }
        }

        [Category("Custom Props")]
        public Color TextColor
        {
            get => textColor;
            set { textColor = value; ForeColor = value; Invalidate(); }
        }

        // === CÁC PROPERTY MỚI CHO SIDEBAR ===
        private int borderRadius = 15;
        private Color hoverBackColor = Color.FromArgb(70, 100, 220, 255);
        private Color normalBackColor = Color.Transparent;
        private Color borderColor = Color.Transparent;

        [Category("Custom Props")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        [Category("Custom Props")]
        public Color HoverBackColor
        {
            get => hoverBackColor;
            set { hoverBackColor = value; Invalidate(); }
        }

        [Category("Custom Props")]
        public Color NormalBackColor
        {
            get => normalBackColor;
            set { normalBackColor = value; Invalidate(); }
        }

        [Category("Custom Props")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        // === CONSTRUCTOR ===
        public Custom_Button()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(240, 50);
            BackColor = normalBackColor;
            ForeColor = textColor;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            TextAlign = ContentAlignment.MiddleLeft;
            ImageAlign = ContentAlignment.MiddleLeft;
            Padding = new Padding(45, 0, 20, 0);
            Cursor = Cursors.Hand;
            TextImageRelation = TextImageRelation.ImageBeforeText;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curve = radius * 2F;
            path.AddArc(rect.X, rect.Y, curve, curve, 180, 90);
            path.AddArc(rect.Right - curve, rect.Y, curve, curve, 270, 90);
            path.AddArc(rect.Right - curve, rect.Bottom - curve, curve, curve, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curve, curve, curve, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = ClientRectangle;
            GraphicsPath path = GetRoundedPath(rect, borderRadius);

            bool isHovered = rect.Contains(PointToClient(Cursor.Position));
            Color currentBackColor = isHovered ? hoverBackColor : normalBackColor;

            // Nếu NormalBackColor = Transparent → dùng BackgroundColor
            if (normalBackColor == Color.Transparent && !isHovered)
                currentBackColor = backgroundColor;

            using (SolidBrush brush = new SolidBrush(currentBackColor))
                g.FillPath(brush, path);

            if (borderColor != Color.Transparent && borderSize > 0)
            {
                using (Pen pen = new Pen(borderColor, borderSize))
                    g.DrawPath(pen, path);
            }

            if (Image != null)
            {
                int iconLeft = 15;
                int iconTop = (Height - Image.Height) / 2;
                g.DrawImage(Image, iconLeft, iconTop);
            }

            if (!string.IsNullOrEmpty(Text))
            {
                int textLeft = 50;
                int textTop = (Height - TextRenderer.MeasureText(Text, Font).Height) / 2;
                TextRenderer.DrawText(
                    g, Text, Font,
                    new Point(textLeft, textTop),
                    ForeColor,
                    Color.Transparent,
                    TextFormatFlags.Left
                );
            }
        }

        protected override void OnMouseEnter(EventArgs e) { base.OnMouseEnter(e); Invalidate(); }
        protected override void OnMouseLeave(EventArgs e) { base.OnMouseLeave(e); Invalidate(); }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (borderRadius > Height) borderRadius = Height;
        }
    }
}