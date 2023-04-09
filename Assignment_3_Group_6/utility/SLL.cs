using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Group_6
{
    public class SLL<T> : LinkedListADT
    {
        //Head and count for linked list
        private Node head;
        private int count;

        public void Append(object data)
        {
            Node newNode = new Node(data);
            //if there is no head the new node becomes the first node
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                //Current node is the head and keeps going till the there is no next node 
                Node currentNode = head;
                while (currentNode.Next != null)
                {
                    //Changes the current node to the next node if there is one 
                    currentNode = currentNode.Next;
                }
                //The next node is the new node
                currentNode.Next = newNode;
            }
            //Increases the count
            count++;
        }

        //Clears the linked list 
        public void Clear()
        {
            //Removes head
            head = null;
        }


        //Checks if linked list has data
        public bool Contains(object data)
        {
            //Pointer to head
            Node currentNode = head;
            while (currentNode != null)
            {
                //If the current nodes data matches the searched data 
                if (currentNode.Data == data)
                {
                    return true;
                }
                //Pointer to the node next to the head
                currentNode = currentNode.Next;
            }
            return false;
        }

        //Deletes the node 
        public void Delete(int index)
        {
            //If index is negative
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            //If the index is 0 (no values)
            if (index == 0)
            {
                head = head.Next;
                return;
            }
            Node currentNode = head;
            Node previousNode = null;
            //Iterates through linked list and the current node is not null
            for (int i = 0; i < index && currentNode != null; i++)
            {
                //Iterates through previous node and current node
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
            //If the current node is null
            if (currentNode == null)
            {
                //Throw exception
                throw new ArgumentOutOfRangeException();
            }
            //The previous nodes next node becomes the current's node next node
            previousNode.Next = currentNode.Next;

            //After deleting updates the count 
            count--;
        }

        //Finding the index of the inputted data
        public int IndexOf(object data)
        {
            //Setting pointer on head node 
            Node currentNode = head;
            int index = 0;
            //Checks while there is a node 
            while (currentNode != null)
            {
                //Checks if the current node matches the data 
                if (currentNode.Data == data)
                {
                    //Returns the index of where the data is 
                    return index;
                }
                //Iterates through the data
                index++;
                //Sets the pointer to the next node
                currentNode = currentNode.Next;
            }
            //If there is no such data in linked list 
            return -1;
        }

        //Inserting data at specific index of the linked list 
        public void Insert(object data, int index)
        {
            //If the index is negative 
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            //Creates the new node with data 
            Node newNode = new Node(data);
            //If the index chosen was the head node 
            if (index == 0)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }
            Node currentNode = head;
            Node previousNode = null;
            //Iterates through the list 
            for (int i = 0; i < index && currentNode != null; i++)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
            //if the index is out of range of the linked list 
            if (currentNode == null && index != Size())
            {
                throw new ArgumentOutOfRangeException();
            }
            //Iterating through the list
            newNode.Next = currentNode;
            previousNode.Next = newNode;

            //Updating count afterwards 
            count++;
        }

        //Checks if the linked list is empty
        public bool IsEmpty()
        {
            //If head null returns true 
            return head == null;
        }

        //Adding node to the front of the list 
        public void Prepend(object data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
            count++;
        }

        //Replacing node data at a specific index 
        public void Replace(object data, int index)
        {
            //if the index is out of range 
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException();
            }

            //Iterating through the list till at index
            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            //Changes the current node to the data specified 
            current.Data = data;
        }

        //Getting node data at specific index 
        public object Retrieve(int index)
        {
            //If the index is out of the range of the linked list 
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }
            //Goes through the list till at specified index 
            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            //Returns the current node's data
            return current.Data;
        }

        //Size of the linked list 
        public int Size()
        {
            //Count is a counter within the linked list
            return count;
        }
    }
}
