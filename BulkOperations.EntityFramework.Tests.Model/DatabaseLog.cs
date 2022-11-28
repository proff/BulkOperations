﻿using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class DatabaseLog
    {
        
        
        
        public int DatabaseLogId { get; set; } 

        
        
        
        public DateTime PostTime { get; set; } 

        
        
        
        public string DatabaseUser { get; set; }

        
        
        
        public string Event { get; set; } 

        
        
        
        public string Schema { get; set; } 

        
        
        
        public string Object { get; set; } 

        
        
        
        public string Tsql { get; set; } 

        
        
        
        public string XmlEvent { get; set; } 
    }
}