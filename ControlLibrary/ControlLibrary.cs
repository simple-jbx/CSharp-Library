using System;
using System.Drawing;
using System.Windows.Forms;


namespace ControlLibrary.ControLocation
{
    /// <summary>
    /// 有关控件操作的一些公共方法
    /// </summary>
    public class ControLocation
    {
        private ControLocation() { }

        /// <summary>
        /// 控件水平居中
        /// </summary>
        /// <param name="parentSize">父控件的Size</param>
        /// <param name="control">要水平居中的控件</param>
        /// <param name="offsetX">水平偏移量</param>
        public static void ControlCenteredHorizontally(in Size parentSize, Control control, int offsetX = 0)
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
        public static void ControlCenteredHorizontally(in Size parentSize, in Point parentLocation, Control control,
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
        public static void ControlCenteredVertical(in Size parentSize, Control control, int offsetY = 0)
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
        public static void ControlCenteredVertical(in Size parentSize, in Point parentLocation, Control control, int offsetY = 0)
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
        public static void ControlCentered(in Size parentSize, Control control, int offsetX = 0, int offsetY = 0)
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
        public static void ControlCentered(in Size parentSize, in Point parentLocation, in Control control, int offsetX = 0,
            int offsetY = 0)
        {
            if (parentSize == null || control == null)
            {
                throw new ArgumentNullException();
            }

            control.Location = new Point(parentLocation.X + parentSize.Width / 2 - control.Width / 2 + offsetX,
                parentLocation.Y + parentSize.Height / 2 - control.Height / 2 + offsetY);
        }

        /// <summary>
        /// 返回窗体新的位置（用于鼠标拖动窗体）
        /// </summary>
        /// <param name="oldLocation">窗体移动前Location</param>
        /// <param name="oldMouseLocation">拖动前鼠标Location</param>
        /// <param name="newMouseLocation">当前鼠标Location</param>
        /// <returns></returns>
        public static Point NewFormLocatioin(in Point oldLocation, in Point oldMouseLocation, in Point newMouseLocation)
        {
            Point newLocation = new Point
            {
                X = oldLocation.X + newMouseLocation.X - oldMouseLocation.X,
                Y = oldLocation.Y + newMouseLocation.Y - oldMouseLocation.Y
            };
            return newLocation;
        }

        /// <summary>
        /// 修改窗体位置（用于鼠标拖动窗体）
        /// </summary>
        /// <param name="form">要修改位置的窗体</param>
        /// <param name="oldLocation">窗体移动前Location</param>
        /// <param name="oldMouseLocation">拖动前鼠标Location</param>
        /// <param name="newMouseLocation">当前鼠标Location</param>
        /// <returns></returns>
        public static void SetFormLocatioin(Form form, in Point oldLocation, in Point oldMouseLocation, in Point newMouseLocation)
        {
            Point newLocation = new Point
            {
                X = oldLocation.X + newMouseLocation.X - oldMouseLocation.X,
                Y = oldLocation.Y + newMouseLocation.Y - oldMouseLocation.Y
            };
            form.Location = newLocation;
        }
    }
}
