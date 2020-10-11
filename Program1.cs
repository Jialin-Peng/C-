using System;

namespace ConsoleApp1
{
    class Vehicle
    {

        protected double Speed;
        protected double MaxSpeed;
        protected double Weight;

       /* public Vehicle(double Speed,double MaxSpeed,double Weight)
        {
            this.Speed = Speed;
            this.MaxSpeed = MaxSpeed;
            this.Weight = Weight;
        }*/

        public void setSpeed(double Speed)
        {
            this.Speed = Speed;
        }
        public double getSpeed()
        {
            return Speed;
        }

        public void setMaxSpeed(double MaxSpeed)
        {
            this.MaxSpeed = MaxSpeed;
        }
        public double getMaxSpeed()
        {
            return MaxSpeed;
        }

        public void setWeight(double Weight)
        {
            this.Weight = Weight;
        }
        public double getWeight()
        {
            return Weight;
        }
        public void run() 
        {
            Console.WriteLine("车辆开始运行");
        }
        public void stop()
        {
            Console.WriteLine("车辆停止运行\n");
        }
    }
    class Bicycle : Vehicle 
    {
        protected double Height;
        protected double Long;

        public Bicycle(double Speed, double MaxSpeed, double Weight,double Height,double Long)
        {
            this.Speed = Speed;
            this.MaxSpeed = MaxSpeed;
            this.Weight = Weight;
            this.Height = Height;
            this.Long = Long;
        }

        public void setHeight(double Height)
        {
            this.Height= Height;
        }
        public double getHeight()
        {
            return Height;
        }

        public void setLong(double Long)
        {
            this.Long = Long;
        }
        public double getLong()
        {
            return Long;
        }
    }

    class Car : Vehicle
    {
        protected double Height;
        protected double Long;
        protected double Width;
        protected int Seat;

        public Car(double Speed, double MaxSpeed, double Weight, double Height, double Long,double Width,int Seat)
        {
            this.Speed = Speed;
            this.MaxSpeed = MaxSpeed;
            this.Weight = Weight;
            this.Height = Height;
            this.Long = Long;
            this.Width = Width;
            this.Seat = Seat;
        }

        public void setHeight(double Height)
        {
            this.Height = Height;
        }
        public double getHeight()
        {
            return Height;
        }

        public void setLong(double Long)
        {
            this.Long = Long;
        }
        public double getLong()
        {
            return Long;
        }

        public void setWidth(double Width)
        {
            this.Width = Width;
        }
        public double getWight()
        {
            return Width;
        }
        public void setSeat(int Seat)
        {
            this.Seat = Seat;
        }
        public int getSeat()
        {
            return Seat;
        }
    }
    class Test
    {
        public static void Main(String[] args)
        {
            Bicycle b = new Bicycle(25, 40, 25, 1.5, 2);
            b.run();
            Console.WriteLine("单车速度为：" + b.getSpeed() +"km/h"+
                            "\n单车最大速度为：" + b.getMaxSpeed()+"km/h"+
                            "\n单车重量为："+b.getWeight()+"kg"+
                            "\n单车高度为："+b.getHeight()+"m"+
                            "\n单车长度为："+b.getLong()+"m");
            b.stop();
            Car c = new Car(80, 150, 1200, 2, 3, 2, 5);
            c.run();
            Console.WriteLine("小轿车速度为：" + c.getSpeed() + "km/h" +
                            "\n小轿车最大速度为：" + c.getMaxSpeed() + "km/h" +
                            "\n小轿车重量为：" + c.getWeight() + "kg" +
                            "\n小轿车高度为：" + c.getHeight() + "m" +
                            "\n小轿车长度为：" + c.getLong() + "m"+
                            "\n小轿车座位数为："+c.getSeat());
            c.stop();
        }
    }
}
