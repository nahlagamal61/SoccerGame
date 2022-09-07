namespace BaseLibrary.BaseEntities
{
    using System;

    public  class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
