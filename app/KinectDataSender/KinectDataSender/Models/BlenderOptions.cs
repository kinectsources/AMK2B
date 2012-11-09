﻿
namespace KinectDataSender.Models
{
    /// <summary>
    /// Blender 側へ反映する際のオプション
    /// </summary>
    public class BlenderOptions
    {
        private double _sizeProportion;
        private double _centerX;
        private double _centerY;
        private double _centerZ;
        private bool _mirror;

        /// <summary>
        /// サイズ比率
        /// </summary>
        public double SizeProportion
        {
            get { return _sizeProportion;  }
            set { _sizeProportion = value; }
        }

        /// <summary>
        /// 中心 x 座標
        /// </summary>
        public double CenterX
        {
            get { return _centerX;  }
            set { _centerX = value; }
        }
        /// <summary>
        /// 中心 y 座標
        /// </summary>
        public double CenterY
        {
            get { return _centerY;  }
            set { _centerY = value; }
        }
        /// <summary>
        /// 中心 z 座標
        /// </summary>
        public double CenterZ
        {
            get { return _centerZ;  }
            set { _centerZ = value; }
        }

        /// <summary>
        /// 向い合っている想定で座標を適用するなら true
        /// </summary>
        public bool Mirror
        {
            get { return _mirror;  }
            set { _mirror = value; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BlenderOptions()
        {
            _sizeProportion = 5;
            _centerX = 0;
            _centerY = 0;
            _centerZ = 0;
            _mirror = false;
        }

        /// <summary>
        /// デストラクタ
        /// </summary>
        ~BlenderOptions()
        {
        }
    }
}
