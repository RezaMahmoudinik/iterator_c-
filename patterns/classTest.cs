using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns
{
    abstract class Agregate
    {
        public abstract Iterator create();
    }
    class ConcreteAgregate : Agregate
    {
        private ArrayList item = new ArrayList();
        public override Iterator create()
        {
            return new ConcreteIterator(this);
        }
        public int counte
        {
            get { return item.Count; }
        }
        public object this[int index]
        {
            get { return item.Count; }
            set    { item.Insert(index, value); }
        }
    }
    abstract class Iterator
    {
        public abstract Object first();
        public abstract Object next();
        public abstract bool done();

        public abstract object items();



    }
    class ConcreteIterator : Iterator
    {
        private ConcreteAgregate agg;
        private int curen = 0;
        public ConcreteIterator(ConcreteAgregate aggregate)
        {
            this.agg = aggregate;
        }
        public override Object first()
        {
            return agg[0];
        }
        public override object next()
        {
            object ret = null;
            if (curen < agg.counte - 1)
            {
                ret = agg[++curen];
            }
            return ret;
        }
        public override bool done()
        {
            return curen >= agg.counte;
        }

        public override object items()
        {
            return agg[curen];


        } 
    

    }

}
