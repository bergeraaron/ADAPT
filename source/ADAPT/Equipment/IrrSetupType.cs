/*******************************************************************************
 * Copyright (C) 2016 AgGateway and ADAPT Contributors
 * Copyright (C) 2016 Deere and Company
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
        //TimeDataSourceEnum //TimeDataPedigree
        public TimeScope TimeScope { get; set; }
        public double SystemLength { get; set; }
        public EnumeratedValue LengthUoM { get; set; }
        public EnumeratedValue AreaTotalUoM { get; set; }
        public EndgunSetupType EndgunSetup { get; set; }
        public double NominalPressure { get; set; }
        public double NominalEfficiency { get; set; }
        public EnumeratedValue PressureUoM { get; set; }
        public PressureLocationEnum PressureLocation { get; set; }



    }
}
