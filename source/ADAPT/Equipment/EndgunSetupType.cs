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


namespace AgGateway.ADAPT.ApplicationDataModel.Equipment
{
    class EndgunSetupType
    {
        public int ManufacturerId { get; set; }
        public string Model { get; set; }
        public EndgunTableEntryType NominalValues { get; set; }
        public EndgunTableEntries TabularValues { get; set; }
    }
}
