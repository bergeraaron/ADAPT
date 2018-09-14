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
using AgGateway.ADAPT.ApplicationDataModel.Representations;

namespace AgGateway.ADAPT.ApplicationDataModel.Equipment
{
    class IrrSectionSetupType
    {
        public IrrSectionSetupType()
        {
            SectionId = CompoundIdentifierFactory.Instance.Create();
        }
        public CompoundIdentifier SectionId { get; private set; }
        public SectionTypeEnum SectionType { get; set; }
        public double InnerDistance { get; set; }
        public double OuterDistance { get; set; }
        public EnumeratedValue SpatialFootprint { get; set; }//MultiPolgonSpatialScopeType
        public double NominalEfficiency { get; set; }
    }
}
