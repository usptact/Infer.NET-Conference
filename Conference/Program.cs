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
            Reviewer r1 = new Reviewer(1);
            Reviewer r2 = new Reviewer(2);
            Reviewer r3 = new Reviewer(3);
            Reviewer r4 = new Reviewer(4);
            Reviewer r5 = new Reviewer(5);
            Reviewer r6 = new Reviewer(6);

            Submission s1 = new Submission(1);
            Submission s2 = new Submission(2);
            Submission s3 = new Submission(3);
            Submission s4 = new Submission(4);
            Submission s5 = new Submission(5);
            Submission s6 = new Submission(6);

            Review[] reviewArray = new Review[21]
            {
                new Review( r1, s2, 3, 2),
                new Review( r1, s4, 4, 1),
                new Review( r1, s5, 2, 3),
                new Review( r2, s1, 1, 2),
                new Review( r2, s2, 3, 1),
                new Review( r2, s4, 5, 3),
                new Review( r3, s3, 2, 1),
                new Review( r3, s4, 4, 2),
                new Review( r3, s5, 3, 2),
                new Review( r4, s1, 1, 3),
                new Review( r4, s3, 5, 2),
                new Review( r4, s6, 4, 2),
                new Review( r5, s1, 1, 1),
                new Review( r5, s2, 4, 1),
                new Review( r5, s3, 3, 1),
                new Review( r5, s4, 2, 1),
                new Review( r5, s5, 4, 1),
                new Review( r5, s6, 5, 1),
                new Review( r6, s1, 2, 3),
                new Review( r6, s3, 2, 1),
                new Review( r6, s6, 5, 2)
            };

            ReviewerCalibration rc = new ReviewerCalibration();

            ReviewerCalibrationResults rcResults = rc.Run(reviewArray);

            var posteriorAccuracy = rcResults.Accuracy;
            var posteriorExpertPrecision = rcResults.ExpertPrecision;
            var posteriorQuality = rcResults.Quality;
            //var posteriorThresholds = rcResults.Thresholds;

            foreach (var kvp in posteriorAccuracy)
                Console.WriteLine("Posterior Accuracy: Key = {0}, Value = {1}", kvp.Key, kvp.Value);

            foreach (var kvp in posteriorExpertPrecision)
                Console.WriteLine("Posterior Expert Precision: Key = {0}, Value = {1}", kvp.Key, kvp.Value);

            foreach (var kvp in posteriorQuality)
                Console.WriteLine("Posterior Quality: Key = {0}, Value = {1}", kvp.Key, kvp.Value);

            //foreach (var kvp in posteriorThresholds)
            //    Console.WriteLine("Posterior Thresholds: Key = {0}, Value = {1}", kvp.Key, kvp.Value);

            Console.ReadKey();
        }
    }
}
