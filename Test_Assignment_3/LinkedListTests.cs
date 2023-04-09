using Assignment_3_Group_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Test_Assignment_3
{
    public class LinkedListTests
    {
        private LinkedListADT linkedList;

        [SetUp]
        public void Setup()
        {
            // Create your concrete linked list class and assign to to linkedList.
            this.linkedList = new SLL<DataAttribute>();
        }

        [TearDown]
        public void TearDown()
        {
            this.linkedList.Clear();
        }

        //Test the linked list is empty.
        [Test]
        public void TestIsEmpty()
        {
            Assert.True(this.linkedList.IsEmpty());
            Assert.AreEqual(0, this.linkedList.Size());
        }

        //Tests appending elements to the linked list.
        [Test]
        public void TestAppendNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            /**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(4, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));

            // Test the third node value is c
            Assert.AreEqual("c", this.linkedList.Retrieve(2));

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(3));
        }

        //Tests prepending nodes to linked list.
        [Test]
        public void testPrependNodes()
        {
            this.linkedList.Prepend("a");
            this.linkedList.Prepend("b");
            this.linkedList.Prepend("c");
            this.linkedList.Prepend("d");

            /**
             * Linked list should now be:
             * 
             * d -> c -> b -> a
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(4, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("d", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("c", this.linkedList.Retrieve(1));

            // Test the third node value is c
            Assert.AreEqual("b", this.linkedList.Retrieve(2));

            // Test the fourth node value is d
            Assert.AreEqual("a", this.linkedList.Retrieve(3));
        }

        //Tests inserting node at valid index.
        [Test]
        public void TestInsertNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Insert("e", 2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> e -> c -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(5, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));

            // Test the third node value is e
            Assert.AreEqual("e", this.linkedList.Retrieve(2));

            // Test the third node value is c
            Assert.AreEqual("c", this.linkedList.Retrieve(3));

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(4));
        }

        //Tests replacing existing nodes data.
        [Test]
        public void TestReplaceNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Replace("e", 2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> e -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(4, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));

            // Test the third node value is e
            Assert.AreEqual("e", this.linkedList.Retrieve(2));

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(3));
        }

        //Tests deleting node from linked list.
        [Test]
        public void TestDeleteNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Delete(2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(3, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(2));
        }

        //Tests finding and retrieving node in linked list.
        [Test]
        public void TestFindNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            /**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

            bool contains = this.linkedList.Contains("b");
            Assert.True(contains);

            int index = this.linkedList.IndexOf("b");
            Assert.AreEqual(1, index);

            string value = (string)this.linkedList.Retrieve(1);
            Assert.AreEqual("b", value);
        }

        //Finding an non-existing node
        [Test]
        public void TestFindNullNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            bool contains = this.linkedList.Contains("Z");
            Assert.False(contains);
        }

        //Finding the index of a non-existing node
        [Test]
        public void TestFindNullNodeIndex()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            int index = this.linkedList.IndexOf("Z");
            Assert.AreEqual(-1, index);
        }

        //Testing if the list is empty
        [Test]
        public void TestEmpty()
        {
            this.linkedList.Append("a");

            bool empty = this.linkedList.IsEmpty();
            Assert.False(empty);

            //Deleting node
            this.linkedList.Delete(0);

            bool empty1 = this.linkedList.IsEmpty();
            Assert.True(empty1);
        }

        //Testing size of the list after changes
        [Test]
        public void TestSize()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            int size = this.linkedList.Size();
            Assert.AreEqual(4, size);

            //Deleting node
            this.linkedList.Delete(1);

            int size1 = this.linkedList.Size();
            Assert.AreEqual(3, size1);
        }

        //Testing putting data out of index range
        [Test]
        public void TestOutOfRange()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            try
            {
                this.linkedList.Insert("e", -1);
                Assert.Fail(); 
            }
            catch
            {
                this.linkedList.Insert("e", 4);
            }

            int size = this.linkedList.Size();

            Assert.AreEqual(5, size);
        }
    }
}
