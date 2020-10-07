﻿using Newtonsoft.Json.Linq;

namespace military_wfh
{
    public class MilitaryPdfInfo
    {
        private readonly JObject jsonObject;

        public Solider Solider { get; }
        public string CeoName { get => jsonObject["ceoName"].ToString(); }

        public MilitaryPdfInfo(JObject jsonObject)
        {
            this.jsonObject = jsonObject;

            Solider = new Solider(
                jsonObject["name"].ToString(),
                jsonObject["birth"].ToString(),
                jsonObject["startDate"].ToString(),
                jsonObject["division"].ToString(),
                jsonObject["phoneNumber"].ToString(),
                jsonObject["workingDate"].ToString(),
                jsonObject["address"].ToString(),
                jsonObject.Value<JArray>("workInfos")
                );
        }
    }
}
