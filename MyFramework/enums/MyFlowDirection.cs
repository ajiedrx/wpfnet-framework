using System.Windows;

namespace Velacro.Enums
{
    public class MyFlowDirection
    {
        private FlowDirection flowDirection;
        public static MyFlowDirection LEFT_TO_RIGHT = new MyFlowDirection(FlowDirection.LeftToRight);
        public static MyFlowDirection RIGHT_TO_LEFT = new MyFlowDirection(FlowDirection.RightToLeft);
        
        private MyFlowDirection(FlowDirection _flowDirection) {
            flowDirection = _flowDirection;
        }

        internal FlowDirection getFlowDirection() {
            return flowDirection;
        }

    }
}
