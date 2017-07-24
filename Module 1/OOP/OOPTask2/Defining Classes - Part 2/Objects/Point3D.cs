using System;

namespace Defining_Classes___Part_2
{
    public struct Point3D
    {
        private static readonly Point3D startCoordinates=new Point3D(0,0,0);
        private int xCoord;
        private int yCoord;
        private int zCoord;

        public int XCoord
        {
            get
            {
                return xCoord;
            }
            private set
            {
                this.xCoord = value;
                if (this.xCoord<-200 || this.xCoord>200)
                {
                    throw new ArgumentOutOfRangeException("The x coordinate must be in range [-200,200]");
                }
            }
        }
        public int YCoord
        {
            get
            {
                return this.yCoord;
            }
            private set
            {
                this.yCoord = value;
                if (this.yCoord < -200 || this.yCoord > 200)
                {
                    throw new ArgumentOutOfRangeException("The y coordinate must be in range [-200,200]");
                }
            }
        }
        public int ZCoord
        {
            get
            {
                return this.zCoord;
            }
            private set
            {
                this.zCoord = value;
                if (this.zCoord < -200 || this.zCoord > 200)
                {
                    throw new ArgumentOutOfRangeException("The x coordinate must be in range [-200,200]");
                }
            }
        }
        public static Point3D StartCoordinates
        {
            get
            {
                return startCoordinates;
            }
        }

        public Point3D(int xCoord,int yCoord,int zCoord):this()
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
            this.ZCoord = zCoord;
        }
        public override string ToString()
        {
            return String.Format("{X coordinte = {0}, Y coordinate = {1},Z coordinate = {2}!}", this.XCoord, this.YCoord, this.ZCoord);
        }
    }
}
