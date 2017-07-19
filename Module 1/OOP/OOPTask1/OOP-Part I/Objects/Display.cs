using System;

namespace OOP_Part_I
{
    public class Display
    {
        private int size;
        private int colorCount;

        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
                if (this.size<=0)
                {
                    throw new ArgumentOutOfRangeException("The size must be larger than 0");
                }
            }
        }
        public int ColorCount
        {
            get
            {
                return this.colorCount;
            }
            set
            {
                this.colorCount = value;
                if (this.colorCount<=0)
                {
                    throw new ArgumentOutOfRangeException("Colors must be more than 0");
                }
            }
        }

        public Display():this(0,0)
        {

        }

        public Display(int size):this(size,0)
        {

        }
        
        public Display(int size,int colorCount)
        {
            this.Size = size;
            this.ColorCount = colorCount;
        }

    }
}
