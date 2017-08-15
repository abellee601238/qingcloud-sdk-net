using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QingCloudSDK.config;
using QingCloudSDK.service;
using System.IO;
using System.Net;
using QingCloudSDK.utils;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace QingCloudSDK
{
    class Program
    {
        static void Main(string[] args)
        {
            Config config = new Config("KLVGRRVCZISPWZWUTTNK", "fWvtysXGLcc3ATXRWwuIVjJ6RRIv3hYtqyF3zgNx");//citrix@citrix.com的key和secret
            config.setProtocol("http");
            config.setHost("api.pekdemo.com");
            config.setPort("80");
            Vxnets vxnets = new Vxnets(config, "pekdemo1");
            Vxnets.JoinVxnetInput vxnetinput = new Vxnets.JoinVxnetInput();
            vxnetinput.setVxnet("vxnet-8vqzj0h");
            vxnetinput.setInstances(new String[] { "i-qn1dyq27" });
            Vxnets.JoinVxnetOutput vxnetoutput = new Vxnets.JoinVxnetOutput();
            vxnetoutput = vxnets.JoinVxnets(vxnetinput);
            Console.WriteLine(vxnetoutput.getRetCode());
            Console.ReadLine();
        }
        /*
        //DeleteImagesInput Demo
        static void Main(string[] args)
        {
            Config config = new Config("KLVGRRVCZISPWZWUTTNK", "fWvtysXGLcc3ATXRWwuIVjJ6RRIv3hYtqyF3zgNx");//citrix@citrix.com的key和secret
            config.setProtocol("http");
            config.setHost("api.pekdemo.com");
            config.setPort("80");
            Image image = new Image(config, "pekdemo1");//zone名称
            Image.DeleteImagesInput input = new Image.DeleteImagesInput();
            input.setZone("pekdemo1");
            input.setImages(new string[] { "img-boqkzmse" });

            Image.DeleteImagesOutput output = new Image.DeleteImagesOutput();

            output = image.DeleteImages(input);

            // Print the return code.
            Console.WriteLine(output.getRetCode());

            // Print the job ID.
            Console.WriteLine(output.getJobId());
            Console.ReadLine();
        }
        */
        /*
        //CaptureInstance Demo
        static void Main(string[] args)
        {
            Config config = new Config("KLVGRRVCZISPWZWUTTNK", "fWvtysXGLcc3ATXRWwuIVjJ6RRIv3hYtqyF3zgNx");//citrix@citrix.com的key和secret
            config.setProtocol("http");
            config.setHost("api.pekdemo.com");
            config.setPort("80");
            Image image = new Image(config, "pekdemo1");//zone名称
            Image.CaptureInstanceInput input = new Image.CaptureInstanceInput();
            input.setZone("pekdemo1");
            input.setImageName("test_centos7x64");
            input.setInstance("i-x96t7kfg");

            Image.CaptureInstanceOutput output = new Image.CaptureInstanceOutput();

            output = image.CaptureInstance(input);

            // Print the return code.
            Console.WriteLine(output.getRetCode());

            // Print the job ID.
            Console.WriteLine(output.getJobId());
            Console.ReadLine();
        }*/

        /*
        //DescribeImages Demo
        static void Main(string[] args)
        {
            Config config = new Config("KLVGRRVCZISPWZWUTTNK", "fWvtysXGLcc3ATXRWwuIVjJ6RRIv3hYtqyF3zgNx");//citrix@citrix.com的key和secret
            config.setProtocol("http");
            config.setHost("api.pekdemo.com");
            config.setPort("80");
            Image image = new Image(config, "pekdemo1");//zone名称
            Image.DescribeImagesInput input = new Image.DescribeImagesInput();
            input.setZone("pekdemo1");
            input.setImages(new string[] { "img-boqkzmse" });

            Image.DescribeImagesOutput output = new Image.DescribeImagesOutput();

            output = image.DescribeImages(input);

            // Print the return code.
            Console.WriteLine(output.getRetCode());

            // Print the job ID.
            Console.WriteLine(output.getImageSet()[0]["status"]);
            Console.WriteLine(output.getImageSet()[0]["features_supported"]);
            Console.ReadLine();
        }
        */
        /*
        //DescribeInstances Demo
        static void Main(string[] args)
        {
            Config config = new Config("KLVGRRVCZISPWZWUTTNK", "fWvtysXGLcc3ATXRWwuIVjJ6RRIv3hYtqyF3zgNx");//citrix@citrix.com的key和secret
            config.setProtocol("http");
            config.setHost("api.pekdemo.com");
            config.setPort("80");
            Instance intance = new Instance(config, "pekdemo1");//zone名称
            Instance.DescribeInstancesInput input = new Instance.DescribeInstancesInput();
            //input.setInstances(new string[] { "i-2o2sq9zw" });
            Instance.DescribeInstancesOutput output = new Instance.DescribeInstancesOutput();

            output = intance.DescribeInstances(input);

            // Print the return code.
            Console.WriteLine(output.getRetCode());
            Console.WriteLine(output.getInstanceSet()[0]["status"]);
            Console.WriteLine(output.getInstanceSet()[0]["vxnets"][0]["role"]);
            Console.ReadLine();
        }
        */

        /*
        //RunInstances Demo
        static void Main(string[] args)
        {
            Config config = new Config("KLVGRRVCZISPWZWUTTNK", "fWvtysXGLcc3ATXRWwuIVjJ6RRIv3hYtqyF3zgNx");//citrix@citrix.com的key和secret
            config.setProtocol("http");
            config.setHost("api.pekdemo.com");
            config.setPort("80");
            Instance intance = new Instance(config, "pekdemo1");//zone名称
            Instance.RunInstancesInput input = new Instance.RunInstancesInput();
            String[] volumes = { "vol-3yleq25h" };
            String[] networks = { "vxnet-0" };
            input.setImageId("img-gp3zihbr");                      //这个参数是我们自己抽取出来的，调试时候需要用现成的常量来代替
            input.setCpu(1);
            input.setMemory(1024);
            input.setInstanceName("test_vm_x");                            //这个参数是我们自己抽取出来的，调试时候需要用现成的常量来代替
            //input.setVolumes(volumes);                      //这个参数是我们自己抽取出来的，调试时候需要用现成的常量来代替
            input.setLoginMode("passwd");
            input.setLoginPassword("Zhu88jie");
            input.setVxnets(networks);                       //这个参数是我们自己抽取出来的，调试时候需要用现成的常量来代替
            input.setZone("pekdemo1");
            input.setCount(2);
            //String[] vxnets  paul:where to ensue the network in catalog? should use the one in profilesetting or creation request?  

            Instance.RunInstancesOutput output = new Instance.RunInstancesOutput();

            output = intance.RunInstances(input);

            // Print the return code.
            Console.WriteLine(output.getRetCode());
            Console.WriteLine(output.getInstances()[0]);
            Console.WriteLine(output.getInstances()[1]);
            // Print the job ID.
            Console.WriteLine(output.getJobId());

            Console.ReadLine();
        }
        */
        /*
         //StartInstances Demo
        static void Main(string[] args)
        {
            Config config = new Config("KLVGRRVCZISPWZWUTTNK", "fWvtysXGLcc3ATXRWwuIVjJ6RRIv3hYtqyF3zgNx");//citrix@citrix.com的key和secret
            config.setProtocol("http");
            config.setHost("api.pekdemo.com");
            config.setPort("80");
            Instance intance = new Instance(config, "pekdemo1");//zone名称
            Instance.StartInstancesInput input = new Instance.StartInstancesInput();
            input.setInstances(new String[] { "i-tj3e7xpl", "i-71x8sg3x" });
            Instance.StartInstancesOutput output = new Instance.StartInstancesOutput();
            output = intance.StartInstances(input);

            // Print the return code.
            Console.WriteLine(output.getRetCode());

            // Print the job ID.
            Console.WriteLine(output.getJobId());
            Console.ReadLine();
        }
         * */

        /*
         //StopInstances Demo
        static void Main(string[] args)
        {
            Config config = new Config("KLVGRRVCZISPWZWUTTNK", "fWvtysXGLcc3ATXRWwuIVjJ6RRIv3hYtqyF3zgNx");//citrix@citrix.com的key和secret
            config.setProtocol("http");
            config.setHost("api.pekdemo.com");
            config.setPort("80");
            Instance intance = new Instance(config, "pekdemo1");//zone名称
            Instance.StopInstancesInput input = new Instance.StopInstancesInput();
            input.setInstances(new String[] { "i-tj3e7xpl", "i-71x8sg3x" });
            Instance.StopInstancesOutput output = new Instance.StopInstancesOutput();
            output = intance.StopInstances(input);

            // Print the return code.
            Console.WriteLine(output.getRetCode());

            // Print the job ID.
            Console.WriteLine(output.getJobId());
            Console.ReadLine();
        }
         * */
    }
}
