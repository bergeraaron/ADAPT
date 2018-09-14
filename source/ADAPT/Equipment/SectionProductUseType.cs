/*******************************************************************************
  * Copyright (C) 2015 AgGateway and ADAPT Contributors
  * Copyright (C) 2015 Deere and Company
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
    class SectionProductUseType
    {
        public int PdtRef { get; set; }//Shorthand integer ID of a product. Should match the ID of a corresponding ProductSetup record under the parent Work Record / Work Order.</
        public double Rate { get; set; }//The meaning of this value should match the rate type specified in the ProductSetup record; i.e., if the ProductSetup record specifies, say, a volume per time rate, this Rate value should be in Liters per minute, or similar.</
        public double Tot { get; set; }//Total product used in this section during this observation. This total should correspond to the makeup (solid or liquid) described in the Product record.</
    }
}
