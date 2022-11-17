using System.Collections.Generic;

namespace Palindrome;
public class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        linkedList.AddLast("xbx");
        linkedList.AddLast("pka");
        linkedList.AddLast("pka");
        linkedList.AddLast("xbx");
    }

    public static bool IsPalindrome<T>(LinkedList<T> linkedList)
    {
        // are the first and last items the same?

        var currentNode = linkedList.First;

        var lastNode = linkedList.Last;

        while( currentNode != null)
        {
            if( currentNode == lastNode )
            {
                return true;

                var nextNode = currentNode.Next;
                var prevNode = lastNode.Previous;

                while( nextNode == prevNode & nextNode.Next == lastNode.Previous)
                {
                    return true;
                }
                
            }
            else
            {
                return false;
            }
        }

        //if( linkedList.First != linkedList.Last)
        //{
        //    return false;
        //}

        //else
        //{
        //    return true;
        //}
        // if so, move toward the middle 


        return true;
    }
}

