using System;
using System.Data.Common;
using System.Threading.Tasks.Dataflow;

namespace ControlWork1
{
    abstract class Bird {
        public Bird()
        {
            
        }
        public int Id { get; set; }
        public int Speed { get; set; }
        
        public bool isNailed { get; set; }
        public int getBaseSpeed()
        {
            return Speed;
        }

        public Bird(int _Id, int _Speed, bool _isNailed)
        {
            Id = _Id;
            Speed = _Speed;
            isNailed = _isNailed;
        }

        public abstract double getSpeed();

    }

    public interface IBird
    {
        double getSpeed();
    }

    abstract class Adapter : IBird
    {
        private readonly Bird _bird;

        public Adapter(Bird bird)
        {
            _bird = bird;
        }

        public double getSpeed()
        {
            return _bird.getSpeed();
        }
    }
    class European : Bird {
    public override double getSpeed() {
        return getBaseSpeed();
    }
    }
    class African : Bird {
        public override double getSpeed() {
        return getBaseSpeed() - 5;
    }
    }
    class NorwegianBlue : Bird {
    public override double getSpeed() {
        return (isNailed) ? 0 : getBaseSpeed();
    }
    }
}