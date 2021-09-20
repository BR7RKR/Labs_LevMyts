namespace Lab_4
{
    public class Rectangle
    {
        private float _width;
        public float width
        {
            get { return _width; }
            set { _width = value; }
        }

        private float _length;
        public float length
        {
            get { return _length; }
            set { _length = value; }
        }

        public float FindSquare()
        {
            return _length * _width;
        }

        public float FindPerimitor()
        {
            return 2 * (_length + _width);
        }
    }
}
