using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPlab7
{
    public class MyList
    {
        private Instance root;

        public Instance this[int index]
        {
            get
            {
                var current = root;
                while (index > 0)
                {
                    current = current.nextInstance;
                    index--;
                }
                return current;
            }
        }

        public void Add(float value)
        {
            if (root == null)
            {
                root = new Instance(value);
                return;
            }
            if (FindLength() == 1)
            {
                root.nextInstance = new Instance(value);
                return;
            }
            var InstanceToInsert = new Instance(value);
            InstanceToInsert.nextInstance = root.nextInstance.nextInstance;
            root.nextInstance.nextInstance = InstanceToInsert;
        }

        public float FindFirsNegative()
        {
            return RecursiveFind(root).data;
        }

        private Instance RecursiveFind(Instance instance)
        {
            if (instance.data < 0)
                return instance;

            if (instance.nextInstance != null)
                return RecursiveFind(instance.nextInstance);
            else
                return null;
        }

        public float FindSumBiggerThenAvarage()
        {
            float avarage = FindAvarage();
            float sum = 0;
            var current = root;

            while (current != null)
            {
                if (current.data >= avarage)
                    sum += current.data;
                current = current.nextInstance;
            }
            return sum;
        }

        private float FindAvarage()
        {
            float sum = 0;
            float length = FindLength();
            var current = root;

            while (current != null)
            {
                sum += current.data;
                current = current.nextInstance;
            }
            return sum / length;
        }

        public int FindLength()
        {
            int length = 0;
            var current = root;
            while (current != null)
            {
                length++;
                current = current.nextInstance;
            }
            return length;
        }

        public MyList CreatePositiveList()
        {
            MyList positiveList = new MyList();
            var current = root;
            for (int i = 0; i < FindLength(); i++)
            {
                if (this[i].data > 0)
                    positiveList.Add(this[i].data);
            }
            return positiveList;
        }

        public void RemoveAllNegative()
        {
            var current = root;
            while (current.nextInstance != null)
            {
                if (current.nextInstance.data < 0)
                    current.nextInstance = current.nextInstance.nextInstance;
                else
                    current = current.nextInstance;
            }
        }
    }
}
