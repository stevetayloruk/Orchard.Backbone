/// <reference path="libs/backbone/backbone.js" />
/// <reference path="libs/jquery/jquery.js" />
/// <reference path="libs/underscore/underscore.js" />





// Main
(function (Backbone, _, $) {
    window.Orchard = {
        Backbone: {
            Models: {},
            Collections: {},
            Views: {},
            Router: {},
            Templates: {},
            Template: function (id) {
                return _.template($("#" + id).html());
            },
            Vent: _.extend({}, Backbone.Events)
        }
    };
  
})(Backbone, _, jQuery);

// Content Items
(function (Backbone, _, $) {
   
    var baseUrl = "/api/RaisingStudio.ContentTypesApi/ContentTypes";

    var url = function (options) {
        return baseUrl + (options.type ? "?name=" + options.type : "");
    };

    Orchard.Backbone.ContentItem = Backbone.Model.extend({
        idAttribute: "Id",

        urlRoot: baseUrl,

        sync: function (method, model, options) {
            var options = options || {};

            if (method === "create") options.url = this.collection.url();
            Backbone.sync(method, model, options);
        }
    });

    Orchard.Backbone.ContentItems = Backbone.Collection.extend({
        model: Orchard.Backbone.ContentItem,

        url: function () {
            return this.collectionUrl;
        },

        initialize: function (options) {
            this.collectionUrl = url(options);
        }
    });
}(Backbone, _, $));

// Api Items
(function (Backbone, _, $) {

    var baseUrl = "/api/";

    var url = function (options) {
        return baseUrl + (options.api ? options.api : "");
    };

    Orchard.Backbone.ApiItem = Backbone.Model.extend({
        idAttribute: "Id",
    });

    Orchard.Backbone.ApiItems = Backbone.Collection.extend({
        model: Orchard.Backbone.ApiItem,

        url: function () {
            return this.apiUrl;
        },

        initialize: function (options) {
            this.apiUrl = url(options);
        }
    });

}(Backbone, _, $));

