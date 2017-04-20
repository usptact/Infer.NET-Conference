using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference
{
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

            ReviewerCalibration rc = new ReviewerCalibration();

            //foreach (Review r in reviews)
            //    rc.Run(r);

            ReviewerCalibrationResults rcResults = rc.Run(reviewArray);
        }
    }
}
