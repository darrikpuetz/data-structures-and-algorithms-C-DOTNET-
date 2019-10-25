using System;
using Xunit;
using LinkedListInsert.Classes;

namespace XUnitTestLinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void Append()
        {
            LinkList append = new LinkList();
            append.Add(1);
            append.Add(45);
            append.Add(64);
            append.Add(25);
            append.Append(12);
            bool worked = append.Worked(12);
            Assert.True(worked);
        }

        [Fact]
        public void NoAppend()
        {

            LinkList append = new LinkList();
            append.Add(1);
            append.Add(45);
            append.Add(64);
            append.Add(88);
            append.Append(3);
            bool worked = append.Worked(12);
            Assert.False(worked);
        }
        [Fact]
        public void AddBefore()
        {

            LinkList append = new LinkList();
            append.Add(1);
            append.Add(45);
            append.Add(64);
            append.Add(88);
            append.InsertBefore(88, 7);
            bool worked = append.Worked(7);
            Assert.True(worked);
        }
        [Fact]
        public void AddAfter()
        {

            LinkList append = new LinkList();
            append.Add(1);
            append.Add(45);
            append.Add(64);
            append.Add(88);
            append.InsertBefore(64, 7);
            bool worked = append.Worked(7);
            Assert.True(worked);
        }
        [Fact]
        public void AddLast()
        {

            LinkList append = new LinkList();
            append.Add(1);
            append.Add(45);
            append.Add(5);
            bool worked = append.Worked(5);
            Assert.True(worked);
        }

        [Fact]

        public void Merge()
        {
            LinkList listOne = new LinkList();
            Node nodeOne = new Node(1);
            Node nodeTwo = new Node(2);
            listOne.Head = nodeOne;
            nodeOne.Next = nodeTwo;
            LinkList listTwo = new LinkList();
            Node nodeEleven = new Node(11);
            Node nodeTwelve = new Node(12);
            Node nodeThirteen = new Node(13);
            listTwo.Head = nodeEleven;
            nodeEleven.Next = nodeTwelve;
            nodeTwelve.Next = nodeTwelve;
            nodeThirteen.Next = nodeThirteen;
            listOne.Merge(listOne, listTwo);
            Assert.Equal(2, nodeEleven.Next.Value);

        }

        [Fact]

        public void NotMerge()
        {
            LinkList listOne = new LinkList();
            Node nodeOne = new Node(-1);
            Node nodeTwo = new Node(2);
            listOne.Head = nodeOne;
            nodeOne.Next = nodeTwo;
            LinkList listTwo = new LinkList();
            Node nodeEleven = new Node(11);
            Node nodeTwelve = new Node(12);
            Node nodeThirteen = new Node(13);
            listTwo.Head = nodeEleven;
            nodeEleven.Next = nodeTwelve;
            nodeTwelve.Next = nodeTwelve;
            nodeThirteen.Next = nodeThirteen;
            Assert.NotNull(listOne.Merge(listOne, listTwo));

        }
    }
}
