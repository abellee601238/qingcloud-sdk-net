using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

using QingCloudSDK.service;
using QingCloudSDK.Attribute;
using QingCloudSDK.config;
using QingCloudSDK.constants;
using QingCloudSDK.exception;
using QingCloudSDK.model;
using QingCloudSDK.request;
using QingCloudSDK.utils;

namespace QingCloudSDK.service
{
    public class Image
    {
        private String zone;
        private Config Config;

        public Image(Config Config) 
        {
            this.Config = Config;
            this.zone = Constant.CLOUD_DEFAULT_ZONE;
        }

        public Image(Config Config, String zone) 
        {
            this.Config = Config;
            this.zone = zone;
        }

        public class DescribeImagesInput : RequestInputModel
        {
            private String []images;
            [Param(paramType = "header", paramName = "images")]
            public String []getImages()
            {
                return this.images;
            }
            public void setImages(String[] images)
            {
                this.images = images;
            }

            private String processorType;
            [Param(paramType = "header", paramName = "processor_type")]
            public String getProcessorType()
            {
                return this.processorType;
            }
            public void setProcessorType(String processorType)
            {
                this.processorType = processorType;
            }

            private String osFamily;
            [Param(paramType = "header", paramName = "os_family")]
            public String getOsFamily()
            {
                return this.osFamily;
            }
            public void setOsFamily(String osFamily)
            {
                this.osFamily = osFamily;
            }

            private String visibility;
            [Param(paramType = "header", paramName = "visibility")]
            public String getVisibility()
            {
                return this.visibility;
            }
            public void setVisibility(String visibility)
            {
                this.visibility = visibility;
            }

            private String provider;
            [Param(paramType = "header", paramName = "provider")]
            public String getProvider()
            {
                return this.provider;
            }
            public void setProvider(String provider)
            {
                this.provider = provider;
            }

            private String[] status;
            [Param(paramType = "header", paramName = "status")]
            public String[] getStatus()
            {
                return this.status;
            }
            public void setStatus(String[] status)
            {
                this.status = status;
            }

            private String searchWord;
            [Param(paramType = "header", paramName = "search_word")]
            public String getSearchWord()
            {
                return this.searchWord;
            }
            public void setSearchWord(String searchWord)
            {
                this.searchWord = searchWord;
            }

            private int verbose;
            [Param(paramType = "header", paramName = "verbose")]
            public int getVerbose()
            {
                return this.verbose;
            }
            public void setVerbose(int verbose)
            {
                this.verbose = verbose;
            }

            private int offset;
            [Param(paramType = "header", paramName = "offset")]
            public int getOffset()
            {
                return this.offset;
            }
            public void setOffset(int offset)
            {
                this.offset = offset;
            }

            private int limit;
            [Param(paramType = "header", paramName = "limit")]
            public int getLimit()
            {
                return this.limit;
            }
            public void setLimit(int limit)
            {
                this.limit = limit;
            }

            private String zone;
            [Param(paramType = "header", paramName = "zone")]
            public String getZone()
            {
                return this.zone;
            }
            public void setZone(String zone)
            {
                this.zone = zone;
            }

            public override String validateParam()
            {

                return null;
            }
        }

        public class DescribeImagesOutput : OutputModel
        {
            private String action;
            [Param(paramType = "query", paramName = "action")]
            public String getAction()
            {
                return this.action;
            }
            public void setAction(String action)
            {
                this.action = action;
            }

            private String imageSet;
            [Param(paramType = "query", paramName = "image_set")]
            public JArray getImageSet()
            {
                return JArray.Parse(this.imageSet);
            }
            public void setImageSet(String imageSet)
            {
                this.imageSet = imageSet;
            }

            private int totalCount;
            [Param(paramType = "query", paramName = "total_count")]
            public int getTotalCount()
            {
                return this.totalCount;
            }
            public void setTotalCount(int totalCount)
            {
                this.totalCount = totalCount;
            }

            private int retCode;
            [Param(paramType = "query", paramName = "ret_code")]
            public int getRetCode()
            {
                return this.retCode;
            }
            public void setRetCode(int retCode)
            {
                this.retCode = retCode;
            }
        }

        public DescribeImagesOutput DescribeImages(DescribeImagesInput input)
        {
            Dictionary<object, object> context = new Dictionary<object, object>();
            context.Add(Constant.PARAM_KEY_REQUEST_ZONE, this.zone);
            context.Add(Constant.CONFIG_CONTEXT_KEY, this.Config);
            context.Add("action", "DescribeImages");
            context.Add("APIName", "DescribeImages");
            context.Add("ServiceName", "Describe Images");
            context.Add("RequestMethod", "GET");
            //context.Add("RequestURI", "/<>");
            //context.Add("instanceNameInput", this.instanceName);

            if (StringUtil.isEmpty(zone))
            {
                throw new QCException("zone can't be empty!");
            }

            OutputModel backModel =
                    ResourceRequestFactory.getResourceRequest()
                            .sendApiRequest(context, input, typeof(DescribeImagesOutput));
            if (backModel != null)
            {
                return (DescribeImagesOutput)backModel;
            }
            return null;
        }

        public class CaptureInstanceInput: RequestInputModel
        {
            private String instance;
            [Param(paramType = "header", paramName = "instance")]
            public String getInstance()
            {
                return this.instance;
            }
            public void setInstance(String instance)
            {
                this.instance = instance;
            }

            private String imageName;
            [Param(paramType = "header", paramName = "image_name")]
            public String getImageName()
            {
                return this.imageName;
            }
            public void setImageName(String imageName)
            {
                this.imageName = imageName;
            }

            private String targetUser;
            [Param(paramType = "header", paramName = "target_user")]
            public String getTargetUser()
            {
                return this.targetUser;
            }
            public void setTargetUser(String targetUser)
            {
                this.targetUser = targetUser;
            }

            private String zone;
            [Param(paramType = "header", paramName = "zone")]
            public String getZone()
            {
                return this.zone;
            }
            public void setZone(String zone)
            {
                this.zone = zone;
            }

            public override String validateParam()
            {
                return null;
            }
        }

        public class CaptureInstanceOutput : OutputModel
        {
            private String action;
            [Param(paramType = "query", paramName = "action")]
            public String getAction()
            {
                return this.action;
            }
            public void setAction(String action)
            {
                this.action = action;
            }

            private String imageId;
            [Param(paramType = "query", paramName = "image_id")]
            public String getImageId()
            {
                return this.imageId;
            }
            public void setImageId(String imageId)
            {
                this.imageId = imageId;
            }

            private String jobId;
            [Param(paramType = "query", paramName = "job_id")]
            public String getJobId()
            {
                return this.jobId;
            }
            public void setJobId(String jobId)
            {
                this.jobId = jobId;
            }

            private int retCode;
            [Param(paramType = "query", paramName = "ret_code")]
            public int getRetCode()
            {
                return this.retCode;
            }
            public void setRetCode(int retCode)
            {
                this.retCode = retCode;
            }
        }

        public CaptureInstanceOutput CaptureInstance(CaptureInstanceInput input)
        {
            Dictionary<object, object> context = new Dictionary<object, object>();
            context.Add(Constant.PARAM_KEY_REQUEST_ZONE, this.zone);
            context.Add(Constant.CONFIG_CONTEXT_KEY, this.Config);
            context.Add("action", "CaptureInstance");
            context.Add("APIName", "CaptureInstance");
            context.Add("ServiceName", "Capture Instance");
            context.Add("RequestMethod", "GET");

            if (StringUtil.isEmpty(zone))
            {
                throw new QCException("zone can't be empty!");
            }

            OutputModel backModel =
                    ResourceRequestFactory.getResourceRequest()
                            .sendApiRequest(context, input, typeof(CaptureInstanceOutput));
            if (backModel != null)
            {
                return (CaptureInstanceOutput)backModel;
            }
            return null;
        }

        public class DeleteImagesInput : RequestInputModel
        {
            private String[] images;
            [Param(paramType = "header", paramName = "images")]
            public String[] getImages()
            {
                return this.images;
            }
            public void setImages(String[] images)
            {
                this.images = images;
            }

            private String zone;
            [Param(paramType = "header", paramName = "zone")]
            public String getZone()
            {
                return this.zone;
            }
            public void setZone(String zone)
            {
                this.zone = zone;
            }

            public override String validateParam()
            {
                return null;
            }
        }

        public class DeleteImagesOutput : OutputModel
        {
            private String action;
            [Param(paramType = "query", paramName = "action")]
            public String getAction()
            {
                return this.action;
            }
            public void setAction(String action)
            {
                this.action = action;
            }

            private String jobId;
            [Param(paramType = "query", paramName = "job_id")]
            public String getJobId()
            {
                return this.jobId;
            }
            public void setJobId(String jobId)
            {
                this.jobId = jobId;
            }

            private int retCode;
            [Param(paramType = "query", paramName = "ret_code")]
            public int getRetCode()
            {
                return this.retCode;
            }
            public void setRetCode(int retCode)
            {
                this.retCode = retCode;
            }
        }

        public DeleteImagesOutput DeleteImages(DeleteImagesInput input)
        {
            Dictionary<object, object> context = new Dictionary<object, object>();
            context.Add(Constant.PARAM_KEY_REQUEST_ZONE, this.zone);
            context.Add(Constant.CONFIG_CONTEXT_KEY, this.Config);
            context.Add("action", "DeleteImages");
            context.Add("APIName", "DeleteImages");
            context.Add("ServiceName", "Delete Images");
            context.Add("RequestMethod", "GET");

            if (StringUtil.isEmpty(zone))
            {
                throw new QCException("zone can't be empty!");
            }

            OutputModel backModel =
                    ResourceRequestFactory.getResourceRequest()
                            .sendApiRequest(context, input, typeof(DeleteImagesOutput));
            if (backModel != null)
            {
                return (DeleteImagesOutput)backModel;
            }
            return null;
        }
    }
}
