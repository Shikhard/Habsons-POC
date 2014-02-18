using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Habsons.WebAPI.AutoMapper
{
    public static class ViewAutoMapper<T>
    {
        public static void ConvertDynamiceToViewObject(T viewObj, dynamic dynamicObj)
        {
            var properties = from prop in viewObj.GetType().GetProperties()
                             select prop;

            foreach (var property in properties)
            {
                dynamic propertyValue = null;
                //var xAttributes = from attr in xmlData.Attributes()
                //                  select attr;
                foreach (var attr in dynamicObj)
                {
                    if (property.Name.ToUpper().Equals(attr.Key.ToString().ToUpper()))
                    {
                        propertyValue = attr.Value;
                        break;
                    }
                }

                if (propertyValue != null)
                {
                    var propertyType = property.PropertyType.FullName;
                    if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        // If it is NULLABLE, then get the underlying type. eg if "Nullable<int>" then this will return just "int"
                        propertyType = property.PropertyType.GetGenericArguments()[0].FullName;
                    }
                    switch (propertyType)
                    {
                        case "System.Int32":
                            {
                                property.SetValue(viewObj, Convert.ToInt32(propertyValue), null);
                                break;
                            }
                        case "System.Nullable[System.Int32]":
                            {
                                property.SetValue(viewObj, Convert.ToInt32(propertyValue), null);
                                break;
                            }
                        case "System.Int64":
                            {
                                property.SetValue(viewObj, Convert.ToInt64(propertyValue), null);
                                break;
                            }
                        case "System.Boolean":
                            {
                                property.SetValue(viewObj, Convert.ToBoolean(Convert.ToInt16(propertyValue)), null);
                                break;
                            }
                        case "System.String":
                            {
                                property.SetValue(viewObj, propertyValue, null);
                                break;
                            }
                        case "System.DateTime":
                            {
                                property.SetValue(viewObj, Convert.ToDateTime(propertyValue), null);
                                break;
                            }
                        case "System.Decimal":
                            {
                                property.SetValue(viewObj, Math.Round(Convert.ToDecimal(propertyValue), 2), null);
                                break;
                            }
                        default:
                            {
                                Type t = Enum.GetUnderlyingType(property.PropertyType);
                                switch (t.FullName)
                                {
                                    case "System.Int16":
                                        {
                                            property.SetValue(viewObj, Convert.ToInt16(propertyValue), null);
                                            break;
                                        }
                                    case "System.Int32":
                                        {
                                            property.SetValue(viewObj, Convert.ToInt32(propertyValue), null);
                                            break;
                                        }
                                }
                                break;
                            }
                    }
                }
            }
        }
    }
}