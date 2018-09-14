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
  *    
  *******************************************************************************/

using AgGateway.ADAPT.ApplicationDataModel.Representations;

namespace AgGateway.ADAPT.ApplicationDataModel.Products
{
    class ProductSummaryType
    {
        public int ProductRef { get; set; } // This is a shorthand identifier for the product, that will be used in section flows. This value allows listing all the products that are used in the work record, document them once here, and refer to them using the ID in the section flow records.The compound identifier it references can also include one or more unique IDs and a source (e.g., a GLN or a URI) for the product ID
        public ProductRateEnum ProductRateType { get; set; }
        public NumericRepresentationValue ProductRateUofM { get; set; }
        public double ProductTotal { get; set; }
        public NumericRepresentationValue ProductTotalUofM { get; set; }
        public int ProductId { get; set; } //Reference ID of the Product as defined in the IrrRefData 
    }
}
