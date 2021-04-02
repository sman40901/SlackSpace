using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackSpace
{
    public class DiskCluster
    {
        public double calculateClusterUsed(double clusterSize, double fileSize)
        {
            // determine if cluster required is whole number or fraction
            // if required cluster is fraction round it up to next number
            return Math.Ceiling(fileSize / clusterSize);
            /*
            double reqCluster = fileSize / clusterSize;
            // determine if cluster required is whole number or fraction
            if (reqCluster % 1 == 0.0)
            {
                return reqCluster;
            }
            // if required cluster is fraction round it up to next number
            return (reqCluster - (reqCluster % 1)) + 1;
            */
        }

        public double calculatePhysicalSize(double clusterSize, double fileSize)
        {
            double reqCLuster = calculateClusterUsed(clusterSize, fileSize);
            return (clusterSize * reqCLuster);
        }

        public double calculateSlackSpace(double clusterSize, double fileSize)
        {

            return calculatePhysicalSize(clusterSize, fileSize) - fileSize;
        }

        public double calculateRamSlack(double logicalFileSizeInBytes)
        {
            // we take sector size as 512
            return calculateSlackSpace(512, logicalFileSizeInBytes);
        }
        public void calculateSpaceSize(double clusterSize, double logicalFileSize)
        {
            Console.WriteLine("******");
            Console.WriteLine("Logical File Size = " + logicalFileSize);
            Console.WriteLine("Cluster Size = " + clusterSize);
            Console.WriteLine("Physical File Size = " + calculatePhysicalSize(clusterSize, logicalFileSize));
            Console.WriteLine("Slack Space = " + calculateSlackSpace(clusterSize, logicalFileSize));
            Console.WriteLine("******");

        }
    }
}
