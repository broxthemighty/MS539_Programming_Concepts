using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WH40K_GUI_UAT_MS539_ML
{
    internal class UnitData
    {
        private string _unitName;
        private string _unitType;
        private string _unitMovement;
        private string _unitToughness;
        private string _unitWounds;
        private string _unitSave;
        private string _unitLeadership;
        private string _unitObjectiveControl;
        private string _unitInvulnerableSave;
        private string _unitFeelNoPain;
        private string _unitModelCount;

        public UnitData()
        {
            //string unitName;
            //string unitType;
            //string unitMovement;
            //string unitToughness;
            //string unitWounds;
            //string unitSave;
            //string unitLeadership;
            //string unitObjectiveControl;
            //string unitInvulnerableSave;
            //string unitFeelNoPain;
            //string unitModelCount;
        }

        public UnitData(string unitName, string unitType, string unitMovement, string unitToughness, string unitWounds, string unitSave, string unitLeadership, string unitObjectiveControl, string unitInvulnerableSave, string unitFeelNoPain, string unitModelCount)
        {
            _unitName = unitName;
            _unitType = unitType;
            _unitMovement = unitMovement;
            _unitToughness = unitToughness;
            _unitWounds = unitWounds;
            _unitSave = unitSave;
            _unitLeadership = unitLeadership;
            _unitObjectiveControl = unitObjectiveControl;
            _unitInvulnerableSave = unitInvulnerableSave;
            _unitFeelNoPain = unitFeelNoPain;
            _unitModelCount = unitModelCount;
        }
    }
}
