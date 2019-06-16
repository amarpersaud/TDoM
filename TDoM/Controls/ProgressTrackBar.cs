using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using TDoM.Core;

namespace TDoM.Controls
{

    /// <summary>
    /// Encapsulates control that visualy displays certain integer value and allows user to change it within desired range. It imitates <see cref="System.Windows.Forms.TrackBar"/> as far as mouse usage is concerned.
    /// </summary>
    [ToolboxBitmap(typeof(TrackBar))]
    [DefaultProperty("BarPrimaryColor")]
    public class ProgressTrackBar : Control
    { 

        #region Value


        /// <summary>
        /// Gets or sets the value of the slider.
        /// </summary>
        /// <value>integer of the slider's value</value>        
        /// <exception cref="T:System.ArgumentOutOfRangeException">exception thrown if max is less than min</exception>
        [Description("Set Slider maximum value")]
        [Category("Behavior")]
        [DefaultValue(100)]
        public int Maximum
        {
            get
            {
                return _maximum;
            }
            set
            {
                _maximum = value;
                if (ValueChanged != null) ValueChanged(this, new EventArgs());
                Invalidate();
            }
        }
        
        private int _maximum = 100;

        /// <summary>
        /// Gets or sets the value of the slider.
        /// </summary>
        /// <value>integer of the slider's value</value>
        [Description("Set Slider minimum value")]
        [Category("Behavior")]
        [DefaultValue(0)]
        public int Minimum
        {
            get
            {
                return _minimum;
            }
            set
            {
                _minimum = value;
                if (ValueChanged != null) ValueChanged(this, new EventArgs());
                Invalidate();
            }
        }
        private int _minimum = 0;
        
        /// <summary>
        /// Gets or sets the value of the slider.
        /// </summary>
        /// <value>integer of the slider's value</value>
        [Description("Set Slider value")]
        [Category("Behavior")]
        [DefaultValue(50)]
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                if (ValueChanged != null) ValueChanged(this, new EventArgs());
                Invalidate();
            }
        }
        private int _value = 50;
        #endregion Value
        #region Thumb
        private Size _thumbSize = new Size(24,24); //size of the thumb

        /// <summary>
        /// Gets or sets the size of the thumb.
        /// </summary>
        /// <value>The size of the thumb.</value>
        /// <exception cref="T:System.ArgumentOutOfRangeException">exception thrown when value is lower than zero</exception>
        [Description("Set Slider thumb size")]
        [Category("Appearance")]
        [DefaultValue(24)]
        public Size ThumbSize
        {
            get { return _thumbSize; }
            set
            {
                int h = value.Height;
                int w = value.Width;
                if (h > 0 && w > 0)
                {
                    _thumbSize = new Size(w, h);
                }
                else
                    throw new ArgumentOutOfRangeException(
                        "TrackSize has to be greather than zero and lower than half of Slider width");

                Invalidate();
            }
        }

        private int ThumbPadding;

        /// <summary>
        /// Gets or sets the offset of the thumb's shadow to the bottom right.
        /// </summary>
        /// <value>The offset of the thumb to the bottom right</value>
        [Description("Set thumb shadow offset")]
        [Category("Appearance")]
        [DefaultValue(2)]
        public int ThumbShadowOffset { get; set; } = 2;
       
        /// <summary>
        /// Gets or sets color of the thumb
        /// </summary>
        /// <value>Color of the thumb body</value>
        [Description("Set color of the thumb")]
        [Category("Appearance")]
        public Color ThumbColor
        {
            get { return _thumbColor; }
            set { _thumbColor = value; Invalidate(); }
        }
        private Color _thumbColor = Color.FromArgb(255, 192, 192, 192);

        /// <summary>
        /// Gets or sets color of the thumb border
        /// </summary>
        /// <value>Color of the thumb border</value>
        [Description("Set color of the thumb's border")]
        [Category("Appearance")]
        public Color ThumbBorderColor
        {
            get { return _thumbBorderColor; }
            set { _thumbBorderColor = value; Invalidate(); }
        }
        private Color _thumbBorderColor = Color.FromArgb(192, 32, 32, 32);

        /// <summary>
        /// Gets or sets color of the thumb's center
        /// </summary>
        /// <value>Color of the thumb center</value>
        [Description("Set color of the thumb's center")]
        [Category("Appearance")]
        public Color ThumbCenterColor
        {
            get { return _thumbCenterColor; }
            set { _thumbCenterColor = value; Invalidate(); }
        } 
        private Color _thumbCenterColor = Color.FromArgb(255, 192, 16, 64);


        /// <summary>
        /// Gets or sets color of the thumb's shadow
        /// </summary>
        /// <value>Color of the thumb shadow</value>
        [Description("Set color of the thumb's shadow")]
        [Category("Appearance")]
        public Color ThumbShadowColor
        {
            get { return _thumbShadowColor; }
            set { _thumbShadowColor = value; Invalidate(); }
        } 
        private Color _thumbShadowColor = Color.FromArgb(128, 128, 128, 128);

        #endregion Thumb
        #region Bar

        private Rectangle barRect;
        private Rectangle barHalfRect;
        private Rectangle barElapsedRect;
        private Rectangle barElapsedHalfRect;

        /// <summary>
        /// Gets or sets color of the bar background
        /// </summary>
        /// <value>Color of the bar</value>
        [Description("Set color of the bar")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "16, 16, 16")]
        public Color BarColor
        {
            get { return _barColor; }
            set { _barColor = value; Invalidate(); }
        } 
        private Color _barColor = Color.FromArgb(255, 224, 224, 224);


        /// <summary>
        /// Gets or sets color of the bar background's shadow
        /// </summary>
        /// <value>Color of the bar's shadow</value>
        [Description("Set color of the bar's shadow")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "32, 32, 32")]
        public Color BarShadowColor
        {
            get { return _barShadowColor; }
            set { _barShadowColor = value; Invalidate(); }
        } 
        private Color _barShadowColor = Color.FromArgb(255, 192, 192, 192);

        /// <summary>
        /// Gets or sets color of the bar background
        /// </summary>
        /// <value>Color of the bar</value>
        [Description("Set primary color of the bar")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "192, 16, 64")]
        public Color BarPrimaryColor
        {
            get { return _barPrimaryColor; }
            set { _barPrimaryColor = value; Invalidate(); }
        } 
        private Color _barPrimaryColor = Color.FromArgb(255, 192, 16, 64);


        /// <summary>
        /// Gets or sets color of the bar's shadow
        /// </summary>
        /// <value>Color of the bar's shadow</value>
        [Description("Set color of the primary color's shadow")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "128, 8, 32")]
        public Color BarPrimaryShadowColor
        {
            get { return _barPrimaryShadowColor; }
            set { _barPrimaryShadowColor = value; Invalidate(); }
        } 
        private Color _barPrimaryShadowColor = Color.FromArgb(255, 128, 8, 32);
        #endregion Bar

        public ProgressTrackBar() : base()
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ThumbPadding = ThumbSize.Width / 2 + 4;
            barRect = ClientRectangle;
            barRect.Inflate(-ThumbPadding, (int)(-barRect.Height * 0.4));


            barHalfRect = barRect;
            barHalfRect.Height = (int)(barRect.Height * 0.7);

            barElapsedRect = barRect;
            barElapsedHalfRect = barHalfRect;

            barElapsedRect.Width = (int)(GetProgressPercentage() * barRect.Width);
            barElapsedHalfRect.Width = barElapsedRect.Width;

            Rectangle thumbRect = GetThumbRect();
            Rectangle thumbCenterRect = thumbRect;
            Rectangle thumbShadowRect = GetThumbRect();

            thumbShadowRect.X += ThumbShadowOffset;
            thumbShadowRect.Y += ThumbShadowOffset;

            thumbCenterRect.Inflate(-thumbCenterRect.Width / 3, -thumbCenterRect.Height / 3);

            using (var g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAlias;
                
                //Draw shadow of background color
                using(Pen p = new Pen(BarShadowColor, 1f))
                {
                    //e.Graphics.DrawLine(p, barRect.X, barRect.Y + barRect.Height / 2, barRect.X + barRect.Width, barRect.Y + barRect.Height / 2);
                   g.FillRectangle(p.Brush, barRect);
                }


                //Draw background color
                using (Pen p = new Pen(BarColor, 1f))
                {
                    g.FillRectangle(p.Brush, barHalfRect);
                }

                //Draw shadow of elapsed rectangle
                using (Pen p = new Pen(BarPrimaryShadowColor, 1f))
                {
                    g.FillRectangle(p.Brush, barElapsedRect);
                }

                //Draw elapsed rectangle
                using (Pen p = new Pen(BarPrimaryColor, 1f))
                {
                    g.FillRectangle(p.Brush, barElapsedHalfRect);
                }

                //Draw thumb shadow
                using (Pen p = new Pen(ThumbShadowColor, 1f))
                {
                    g.FillEllipse(p.Brush, thumbShadowRect);
                }

                //Draw thumb
                using (Pen p = new Pen(ThumbColor, 1f))
                {
                    g.FillEllipse(p.Brush, thumbRect);
                }

                //Draw thumb center
                using (Pen p = new Pen(ThumbCenterColor, 1f))
                {
                    g.FillEllipse(p.Brush, thumbCenterRect);
                }
                //Draw thumb borders
                using (Pen p = new Pen(ThumbBorderColor, 0.25f))
                {
                    g.DrawEllipse(p, thumbRect);
                    g.DrawEllipse(p, thumbCenterRect);
                }
            }
        }

        #region Helper Methods

        public double GetProgressPercentage()
        {
            return (double)(Value - Minimum) / (Maximum - Minimum);
        }
        public void SetProgressPercentage(double percentage)
        {
            this.Value = (int)(percentage * (Maximum - Minimum) + Minimum);
        }
        public Rectangle GetThumbRect()
        {
            int x = barRect.X + (int)(GetProgressPercentage() * barRect.Width) - (ThumbSize.Width/2);
            int y = barRect.Y + (barRect.Height / 2) - (ThumbSize.Width/2);

            return new Rectangle(new Point(x, y), ThumbSize);
        }

        #endregion Helper Methods

        #region Events
        /// <summary>
        /// Fires when Slider position has changed
        /// </summary>
        [Description("Event fires when the Value property changes")]
        [Category("Action")]
        public event EventHandler ValueChanged;

        /// <summary>
        /// Fires when Slider position is changed by the user
        /// </summary>
        [Description("Event fires when the user changes the value")]
        [Category("Action")]
        public event EventHandler UserValueChanged;

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown"></see> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs"></see> that contains the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left && (barRect.Contains(e.Location) || GetThumbRect().Contains(e.Location)))
            {
                Capture = true;
                if (UserValueChanged != null) UserValueChanged(this, new EventArgs());
                OnMouseMove(e);
            }
        }

        private bool mouseInThumbRegion = false;

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseMove"></see> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs"></see> that contains the event data.</param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Rectangle thumbRect = GetThumbRect();
            mouseInThumbRegion = thumbRect.Contains(e.Location);
            if (Capture & e.Button == MouseButtons.Left)
            {


                double percentage = (double)(e.Location.X - ClientRectangle.X - ThumbPadding) / (ClientRectangle.Width - ThumbPadding*2);
                _value = (int)((percentage * (Maximum-Minimum) + Minimum).Clamp(_minimum, _maximum));
                
                if (UserValueChanged != null) UserValueChanged(this, new EventArgs());
            }
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseUp"></see> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs"></see> that contains the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Capture = false;
            Rectangle thumbRect = GetThumbRect();
            mouseInThumbRegion = thumbRect.Contains(e.Location);
            if (UserValueChanged != null) UserValueChanged(this, new EventArgs());
            Invalidate();
        }

        #endregion Events



    }
}
