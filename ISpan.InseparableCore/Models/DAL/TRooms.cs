﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ISpan.InseparableCore.Models.DAL
{
    public partial class TRooms
    {
        public TRooms()
        {
            TSessions = new HashSet<TSessions>();
            TTicketOrderDetails = new HashSet<TTicketOrderDetails>();
        }

        public int FRoomId { get; set; }
        public int FCinemaId { get; set; }
        public string FRoomName { get; set; }

        public virtual TCinemas FCinema { get; set; }
        public virtual ICollection<TSessions> TSessions { get; set; }
        public virtual ICollection<TTicketOrderDetails> TTicketOrderDetails { get; set; }
    }
}