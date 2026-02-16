namespace OnlineElection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] persons = [0, 1, 0, 1, 1];
            int[] times = [24, 29, 31, 76, 81];
            var topVotedCandidate = new TopVotedCandidate(persons, times);

            int[][] queries = [[28], [24], [29], [77], [30], [25], [76], [75], [81], [80]];

            foreach (var query in queries)
            {
                Console.WriteLine(topVotedCandidate.Q(query[0]));
            }
        }
    }
}

public class TopVotedCandidate
{
    private int[] _topVotedCandidates { get; set; }
    private int[] _times { get; set; }

    public TopVotedCandidate(int[] persons, int[] times)
    {
        _topVotedCandidates = BuildTopVotedCandidates(persons, times);
        _times = times;
    }

    public int Q(int t)
    {
        return _topVotedCandidates[TopVotedCandidateIndex(t)];
    }

    private int TopVotedCandidateIndex(int t)
    {
        int left = 0;
        int right = _times.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (_times[mid] <= t)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return right;
    }

    private int[] BuildTopVotedCandidates(int[] persons, int[] times)
    {
        int[] topVotedCandidates = new int[persons.Length];
        var voteByCandidates = new Dictionary<int, int>();
        int currentTopVotedCandidate = -1;

        for (int i = 0; i < persons.Length; i++)
        {
            int currentVotedPerson = persons[i];
            if (!voteByCandidates.TryGetValue(currentTopVotedCandidate, out var topVote))
            {
                currentTopVotedCandidate = currentVotedPerson;
                voteByCandidates[currentVotedPerson] = 1;
                topVotedCandidates[i] = currentVotedPerson;
                continue;
            }

            if (!voteByCandidates.TryGetValue(currentVotedPerson, out var currentVote))
            {
                currentVote = 0;
            }

            currentVote++;
            voteByCandidates[currentVotedPerson] = currentVote;

            if (topVote <= currentVote)
            {
                currentTopVotedCandidate = currentVotedPerson;
            }

            topVotedCandidates[i] = currentTopVotedCandidate;
        }
        return topVotedCandidates;
    }
}

/**
 * Your TopVotedCandidate object will be instantiated and called as such:
 * TopVotedCandidate obj = new TopVotedCandidate(persons, times);
 * int param_1 = obj.Q(t);
 */