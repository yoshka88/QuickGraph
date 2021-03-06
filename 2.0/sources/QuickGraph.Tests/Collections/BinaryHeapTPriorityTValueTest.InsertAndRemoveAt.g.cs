// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using System.Collections.Generic;
using QuickGraph.Unit;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph.Collections
{
    public partial class BinaryHeapTPriorityTValueTest
    {
        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndRemoveAt01()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(0);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            this.InsertAndRemoveAt<int, int>(binaryHeap, keyValuePairs, 2);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndRemoveAt02()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            this.InsertAndRemoveAt<int, int>(binaryHeap, keyValuePairs, 3);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndRemoveAt03()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            this.InsertAndRemoveAt<int, int>(binaryHeap, keyValuePairs, 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndRemoveAt04()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(0);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            this.InsertAndRemoveAt<int, int>(binaryHeap, keyValuePairs, 3);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndRemoveAt05()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(0);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            this.InsertAndRemoveAt<int, int>(binaryHeap, keyValuePairs, 5);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndRemoveAt06()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(0);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(276594238, default(int));
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(1300332994, default(int))
              ;
            keyValuePairs[1] = s1;
            this.InsertAndRemoveAt<int, int>(binaryHeap, keyValuePairs, 5);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndRemoveAt07()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(-803902696, default(int))
              ;
            keyValuePairs[1] = s0;
            this.InsertAndRemoveAt<int, int>(binaryHeap, keyValuePairs, 5);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndRemoveAt08()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(-803902696, default(int))
              ;
            keyValuePairs[1] = s0;
            this.InsertAndRemoveAt<int, int>(binaryHeap, keyValuePairs, 5);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndRemoveAt09()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(2);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(153397576, default(int));
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(153397576, default(int));
            keyValuePairs[1] = s1;
            this.InsertAndRemoveAt<int, int>(binaryHeap, keyValuePairs, 0);
        }

    }
}
