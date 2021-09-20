namespace Lab_4
{
    class Circle
    {
        private float _diametor;
        public float diametor
        {
            get { return _diametor; }
            set { _diametor = value; }
        }

        public float FindLength()
        {
            const float PI = 3.14f;

            return PI * _diametor;
        }


    }
}
