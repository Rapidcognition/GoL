using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using SkiaSharp;

namespace GoLApp
{
    class UpdateCell : BoxView
    {
        public event EventHandler Tapped;
        public bool isAlive;
        public UpdateCell()
        {
            BackgroundColor = Color.White;
            TapGestureRecognizer tapGesture = new TapGestureRecognizer();
            
            tapGesture.Tapped += (sender, args) =>
            {
                this.isAlive = true;
                Tapped?.Invoke(this.BackgroundColor = Color.Black, EventArgs.Empty);
            };
            GestureRecognizers.Add(tapGesture);
        }
        public int Col { set; get; }

        public int Row { set; get; }

        public bool IsAlive
        {
            set
            {
                if (isAlive != value)
                {
                    isAlive = value;
                    BackgroundColor = isAlive ? Color.Black : Color.White;
                }
            }
            get
            {
                return isAlive;
            }
        }
    }
}