using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorDemoConsoleApp
{
    class FamilyMemberIterator : IEnumerator<FamilyMember>
    {           
        private IList<FamilyMember> _familyMembers;
        private const int _INITIAL_POSITION = -1;
        private int _position = _INITIAL_POSITION;

        public FamilyMember Current => SetCurrent();        

        object IEnumerator.Current => Current;

        public FamilyMemberIterator(IList<FamilyMember> familyMembers)
        {
            _familyMembers = familyMembers;
        }

        public bool MoveNext()
        {
            _position++;
            return _position > (_familyMembers.Count - 1) ? false : true;
        }

        public void Reset()
        {
            _position = _INITIAL_POSITION;
        }

        public void Dispose() { }

        private FamilyMember SetCurrent() => _familyMembers[_position];
    }
}
