using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.CodeDom.Compiler;
using System.CodeDom;

namespace reflection
{
    public class to_json
    {
        private string output;

        //Constructor
        public to_json()
        {
            output = "";
        }

        //Calls display function to properly format JSON file
        public string getJson(object obj)
        {
            return "{\n" + Display(obj, 1) + "}";
        }

        //Uses reflection to grab object properties to then be displayed in a JSON format 
        private string Display(object obj, int depth = 0)
        {
            //Holds object properties to be sorted alphabetically
            List<PropertyInfo> sorted = new List<PropertyInfo>();

            foreach (var prop in obj.GetType().GetProperties())
            {
                sorted.Add(prop);
            }

            //Sorts alphabetically
            sorted = sorted.OrderBy(x => x.Name).ToList();

            //Runs through each object and its properties to format into JSON
            for (int i = 0; i < sorted.Count; i++)
            {
                //Variable used to check if the property is the last one in the list
                var prop = sorted[i];

                //Variable used to see if the property of the attribute is a null value
                bool is_null = false;

                string name = ": ";

                //Places a comma at the end of the property if it isn't the last on in the list
                string comma = "";
                if (i < sorted.Count - 1)
                {
                    comma = ",";
                }

                //All null properties are placed in the JSON format as "null"
                if (prop.GetValue(obj) == null)
                {
                    name += "null" + comma;
                    is_null = true;
                }

                //If statement to make make sure the properties with null values are checked and used correctly
                bool checkObj = (is_null) ? false : prop.GetValue(obj).ToString().Contains("reflection.");


                if (checkObj)
                {
                    name += "{";
                }
                else if (!is_null)
                {
                    //try {
                    //    double number = Convert.ToDouble(prop.GetValue(obj));
                    //    name += prop.GetValue(obj) + comma;
                    //} catch {
                    //    name += "\"" + prop.GetValue(obj) + "\"" + comma;
                    //}

                    //Strings are converted to their literal string form to ensure all escaped characters are included in JSON
                    if(prop.GetValue(obj).GetType().ToString() == "System.String" || prop.GetValue(obj).GetType().ToString() == "System.Char")
                    {
                        name += ToLiteral(prop.GetValue(obj).ToString()) + comma;
                    }
                    //All boolean statements must be lowercase in the JSON format
                    else if (prop.GetValue(obj).GetType().ToString() == "System.Boolean")
                    {
                        name += prop.GetValue(obj).ToString().ToLower() + comma;   
                    }
                    else
                    {
                        //All double variables are formatted to only the first decimal point in the JSON format
                        if(prop.GetValue(obj).GetType().ToString() == "System.Double")
                        {
                           name += string.Format("{0:0.0#}", prop.GetValue(obj)) + comma;
                        }
                        else
                        {
                            name += prop.GetValue(obj) + comma;
                        }

                    }

                }

                //Call the indent function to make sure each property is indented correctly as it is recursively called
                output += printIndent("\"" + prop.Name + "\"" + name, depth);

                if (checkObj)
                {
                    Display(prop.GetValue(obj), depth + 1);
                    output += printIndent("}" + comma, depth);
                }
            }

            return output;
        }


        //Function to make sure the JSON file is indented correctly
        public string printIndent(string text, int depth)
        {
            string result = "";
            for (int i = 0; i < depth; i++)
            {
                result += "\t";
            }
            result += text + "\n";

            return result;
        }

        //Returns the string value in the literal form which ensures all escape characters are a part of the value
        private static string ToLiteral(string input)
        {
            using (var writer = new StringWriter())
            {
                using (var provider = CodeDomProvider.CreateProvider("CSharp"))
                {
                    provider.GenerateCodeFromExpression(new CodePrimitiveExpression(input), writer, null);
                    return writer.ToString();
                }
            }
        }

    }
}
