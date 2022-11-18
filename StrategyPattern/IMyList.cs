using Common;

namespace Common
{
    public interface IMyList
    {
        void SwitchNodesCheaterVersion(Node argFirstNode, Node argSecondNode);
        void SetSortStrategy(SortStrategy sortStrategy);
        Node GetFirst();
        void Sort();
    }
}