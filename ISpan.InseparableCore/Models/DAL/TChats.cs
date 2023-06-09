﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ISpan.InseparableCore.Models.DAL
{
    public partial class TChats
    {
        /// <summary>
        /// 聊天流水號
        /// </summary>
        public long FMessageId { get; set; }
        /// <summary>
        /// 發送者的會員ID
        /// </summary>
        public int FSenderId { get; set; }
        /// <summary>
        /// 接收者的會員ID
        /// </summary>
        public int FReceiverId { get; set; }
        /// <summary>
        /// 訊息內容
        /// </summary>
        public string FMessage { get; set; }
        /// <summary>
        /// 訊息發送時間
        /// </summary>
        public DateTime FSendTime { get; set; }

        public virtual TMembers FReceiver { get; set; }
        public virtual TMembers FSender { get; set; }
    }
}