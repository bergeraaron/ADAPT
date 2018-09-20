/*******************************************************************************
 * Copyright (C) 2016 AgGateway and ADAPT Contributors
 * 
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
 *
 * Contributors:
 * 
 *******************************************************************************/


using AgGateway.ADAPT.ApplicationDataModel.Common;
using AgGateway.ADAPT.ApplicationDataModel.Logistics;
using AgGateway.ADAPT.ApplicationDataModel.ReferenceLayers;
using AgGateway.ADAPT.ApplicationDataModel.Representations;
using AgGateway.ADAPT.ApplicationDataModel.Shapes;
using AgGateway.ADAPT.ApplicationDataModel.Notes;

namespace AgGateway.ADAPT.ApplicationDataModel.Equipment
{
    class IrrSetupType
    {
        public IrrSetupType()
        {
            Id = CompoundIdentifierFactory.Instance.Create();
        }

        public CompoundIdentifier Id { get; private set; }
        public int SystemId { get; set; }
        public PositionType SystemLocation { get; set; }
        public int GrowerId { get; set; }
        public int FarmId { get; set;}
        public int FieldId { get; set; }
        public int CropzoneId { get; set; }
        public IrrSectionSetupType SectionSetup { get; set; }
        public SpatialAttribute SpatialFootprint { get; set; }
        public LineString GuidancePath { get; set; }
        public CornerArmTypeEnum CornerArmType { get; set; }
        public FlowDataSourceEnum FlowDataPedigree { get; set; }
        public GpsSourceEnum LocationDataPedigree { get; set; }
        public TimeDataSourceEnum TimeDataPedigree { get; set; }
        public TimeScope TimeScope { get; set; }
        public double SystemLength { get; set; }
        public EnumeratedValue LengthUoM { get; set; }
        public EnumeratedValue AreaTotalUoM { get; set; }
        public EndgunSetupType EndgunSetup { get; set; }
        public double NominalPressure { get; set; }
        public double NominalEfficiency { get; set; }
        public EnumeratedValue PressureUoM { get; set; }
        public PressureLocationEnum PressureLocation { get; set; }
        public double NominalFlow { get; set; }
        public EnumeratedValue FlowUoM { get; set; }
        public EnumeratedValue DepthUoM { get; set; }
        public EnumeratedValue WaterTotalUoM { get; set; }
        public EnumeratedValue ProductRateUoM { get; set; }
        public EnumeratedValue ProductTotalUoM { get; set; }
        public EnumeratedValue NominalFullCircleTime { get; set; }
        public Note Note { get; set; }
        public double BearingOffset { get; set; }
        public string Description { get; set; }
    }
}
