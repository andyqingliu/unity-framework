﻿using UnityEngine;

/***
 * BasePanel.cs
 * 
 * @author abaojin
 */
namespace GameEngine
{
    /// <summary>
    /// 所有界面基类
    /// </summary>
    public class BasePanel : MonoBehaviour
    {
        [SerializeField]
        private PanelInfo mViewInfo;

        public PanelInfo ViewInfo 
        {
            get {
                return mViewInfo;
            }
            private set {
                mViewInfo = value;
            }
        }

        public virtual void Init() { }

    }
}

