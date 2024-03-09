﻿namespace Kreta.Shared.Models
{
    public class SchoolClassSubjects : IDbEntity<SchoolClassSubjects>
    {
        public SchoolClassSubjects()
        {
            Id = Guid.Empty;
            SchoolClassId = Guid.Empty;
            SubjectId = Guid.Empty;
            NumberOfHours = -1;
            TheHoursInOne = false;
        }

        public SchoolClassSubjects(Guid id, Guid schoolClassId, Guid subjectId, int numberOfHours, bool theHoursInOne)
        {
            Id = id;
            SchoolClassId = schoolClassId;
            SubjectId = subjectId;
            NumberOfHours = numberOfHours;
            TheHoursInOne = theHoursInOne;
        }

        public Guid Id { get; set; }
        public Guid SchoolClassId { get; set; }
        public virtual SchoolClass? SchoolClass { get; set; }
        public Guid SubjectId { get; set; }
        public virtual Subject? Subject { get; set; }
        public int NumberOfHours { get; set; }
        public bool TheHoursInOne { get; set; }
        public bool HasId => Id != Guid.Empty;
    }
}