﻿using System;
using Microsoft.Kinect;

namespace KinectDataSender.Models.Events
{
    public class SkeletonUpdateEventArgs : EventArgs
    {
        private KinectSensor _kinect;
        private SkeletonFrame _skeletonFrame;

        /// <summary>
        /// Kinect センサー
        /// </summary>
        public KinectSensor Kinect
        {
            get { return _kinect;  }
            set { _kinect = value; }
        }

        /// <summary>
        /// スケルトンのフレームデータ
        /// </summary>
        public SkeletonFrame SkeletonFrame
        {
            get { return _skeletonFrame;  }
            set { _skeletonFrame = value; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SkeletonUpdateEventArgs()
        {
            _kinect        = null;
            _skeletonFrame = null;
        }

        /// <summary>
        /// デストラクタ
        /// </summary>
        ~SkeletonUpdateEventArgs()
        {
        }
    }
}
