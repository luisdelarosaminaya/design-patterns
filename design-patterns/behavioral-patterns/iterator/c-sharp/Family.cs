using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorDemoConsoleApp
{
    class Family : IEnumerable<FamilyMember>
    {
        private readonly FamilyMember[] _familyMembers;

        public Family()
        {
            _familyMembers = new FamilyMember[]
            {
                new FamilyMember { Name = "Luis", Age = 22 },
                new FamilyMember { Name = "Lismary", Age = 26},
                new FamilyMember { Name = "Maria", Age = 31 },
                new FamilyMember { Name = "Luis Jr.", Age = 31 }
            };
        }

        IEnumerator<FamilyMember> IEnumerable<FamilyMember>.GetEnumerator() => new FamilyMemberIterator(_familyMembers);

        IEnumerator IEnumerable.GetEnumerator()
        {
            var family = this as IEnumerable<FamilyMember>;
            return family.GetEnumerator();
        }
    }
}
