﻿namespace KarTeYoSis
{
    // IEntity interface
    public interface IEntity
    {
        int Id { get; set; }
        bool IsDeleted { get; set; }
    }

}