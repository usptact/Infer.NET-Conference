using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference
{
    // Collection of Review objects. This class implements IEnumerable so that it can be used with ForEach syntax.
    public class Reviews : IEnumerable
    {
        private Review[] _review;
        public Reviews(Review[] rArray)
        {
            _review = new Review[rArray.Length];
            for (int i = 0; i < rArray.Length; i++)
                _review[i] = rArray[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public ReviewEnum GetEnumerator()
        {
            return new ReviewEnum(_review);
        }
    }

    public class ReviewEnum : IEnumerator
    {
        public Review[] _review;

        int position = -1;

        public ReviewEnum(Review[] list)
        {
            _review = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _review.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Review Current
        {
            get
            {
                try
                {
                    return _review[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Review[] reviewArray = new Review[18]
            {
                new Review( new Reviewer(1), new Submission(2), 3, 2),
                new Review( new Reviewer(1), new Submission(4), 4, 1),
                new Review( new Reviewer(1), new Submission(5), 2, 3),
                new Review( new Reviewer(2), new Submission(1), 4, 2),
                new Review( new Reviewer(2), new Submission(2), 3, 1),
                new Review( new Reviewer(2), new Submission(4), 5, 3),
                new Review( new Reviewer(3), new Submission(3), 2, 1),
                new Review( new Reviewer(3), new Submission(4), 4, 2),
                new Review( new Reviewer(3), new Submission(5), 3, 2),
                new Review( new Reviewer(4), new Submission(1), 3, 1),
                new Review( new Reviewer(4), new Submission(3), 5, 2),
                new Review( new Reviewer(4), new Submission(6), 4, 2),
                new Review( new Reviewer(5), new Submission(1), 2, 1),
                new Review( new Reviewer(5), new Submission(2), 4, 1),
                new Review( new Reviewer(5), new Submission(3), 3, 1),
                new Review( new Reviewer(5), new Submission(4), 2, 1),
                new Review( new Reviewer(5), new Submission(5), 4, 1),
                new Review( new Reviewer(5), new Submission(6), 5, 1)
            };

            Reviews reviews = new Reviews(reviewArray);

            ReviewerCalibration rc = new ReviewerCalibration();

            ReviewerCalibrationResults rcResults = rc.Run(reviews);
        }
    }
}
