﻿/*******************************************************************************
 * Copyright (C) 2016 AgGateway and ADAPT Contributors
 * Copyright (C) 2016 Deere and Company
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
 *
 * Contributors:
 *    Justin Sliekers - implement device element changes, initial creation
 *******************************************************************************/

using AgGateway.ADAPT.ApplicationDataModel.Representations;

namespace AgGateway.ADAPT.ApplicationDataModel.Equipment
{
    public class MachineConfiguration : DeviceElementConfiguration
    {
        public NumericRepresentationValue GpsReceiverXOffset {get; set;}

        public NumericRepresentationValue GpsReceiverYOffset { get; set; }

        public NumericRepresentationValue GpsReceiverZOffset { get; set; }

        public OriginAxleLocationEnum OriginAxleLocation;
    }
}
