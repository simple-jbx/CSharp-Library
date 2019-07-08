using System;
using System.Drawing;
using System.Windows.Forms;


namespace ControlLibrary
{
    /// <summary>
    /// 有关控件操作的一些公共方法
    /// </summary>
    public class ControlLibrary
    {
        private ControlLibrary() { }

        /// <summary>
        /// 控件水平居中
        /// </summary>
        /// <param name="parentSize">父控件的Size</param>
        /// <param name="control">要水平居中的控件</param>
        /// <param name="offsetX">水平偏移量</param>
        public static void controlCenteredHorizontally(Size parentSize, Control control, int offsetX = 0)
        {
            if (parentSize == null || control == null)
            {
                throw new ArgumentNullException();
            }
            control.Location = new Point(parentSize.Width / 2 - control.Width / 2 + offsetX, control.Location.Y);
        }

        /// <summary>
        /// 控件水平居中
        /// </summary>
        /// <param name="parentSize">父控件的Size</param>
        /// <param name="parentLocation">父控件的Location</param>
        /// <param name="control">要水平居中的控件</param>
        /// <param name="offsetX">水平偏移量</param>
        public static void controlCenteredHorizontally(Size parentSize, Point parentLocation, Control control,
            int offsetX = 0)
        {
            if (parentSize == null || control == null)
            {
                throw new ArgumentNullException();
            }
            control.Location = new Point(parentLocation.X + parentSize.Width / 2 - control.Width / 2 + offsetX,
                parentLocation.Y + control.Location.Y);
        }

        /// <summary>
        /// 控件垂直居中
        /// </summary>
        /// <param name="parentSize">父控件Size</param>
        /// <param name="control">要垂直居中的控件</param>
        /// <param name="offsetY">垂直偏移量</param>
        public static void controlCenteredVertical(Size parentSize, Control control, int offsetY = 0)
        {
            if (parentSize == null || control == null)
            {
                throw new ArgumentNullException();
            }
            control.Location = new Point(control.Location.X, parentSize.Height / 2 - control.Height / 2 + offsetY);
        }

        /// <summary>
        /// 控件垂直居中
        /// </summary>
        /// <param name="parentSize">父控件的Size</param>
        /// <param name="parentLocation">父控件的Location</param>
        /// <param name="control">要垂直居中的控件</param>
        /// <param name="offsetY">垂直偏移量</param>
        public static void controlCenteredVertical(Size parentSize, Point parentLocation, Control control, int offsetY = 0)
        {
            if (parentSize == null || control == null)
            {
                throw new ArgumentNullException();
            }
            control.Location = new Point(parentLocation.X + control.Location.X,
                parentLocation.Y + parentSize.Height / 2 - control.Height / 2 + offsetY);
        }


        /// <summary>
        /// 控件水平+垂直居中
        /// </summary>
        /// <param name="parentSize">父控件的Size</param>
        /// <param name="control">要居中的控件</param>
        /// <param name="offsetX">水平偏移量</param>
        /// <param name="offsetY">垂直偏移量</param>
        /// <returns></returns>
        public static void controlCentered(Size parentSize, Control control, int offsetX = 0, int offsetY = 0)
        {
            if (parentSize == null || control == null)
            {
                throw new ArgumentNullException();
            }

            control.Location = new Point(parentSize.Width / 2 + offsetX - control.Width / 2,
                parentSize.Height / 2 + offsetY - control.Height);
        }

        /// <summary>
        /// 控件水平+垂直居中
        /// </summary>
        /// <param name="parentSize">父控件的Size</param>
        /// <param name="parentLocation">父控件的Location</param>
        /// <param name="control">要居中的控件</param>
        /// <param name="offsetX">水平偏移量</param>
        /// <param name="offsetY">垂直偏移量</param>
        public static void controlCentered(Size parentSize, Point parentLocation, Control control, int offsetX = 0,
            int offsetY = 0)
        {
            if (parentSize == null || control == null)
            {
                throw new ArgumentNullException();
            }

            control.Location = new Point(parentLocation.X + parentSize.Width / 2 - control.Width / 2 + offsetX,
                parentLocation.Y + parentSize.Height / 2 - control.Height / 2 + offsetY);
        }
    }
}
