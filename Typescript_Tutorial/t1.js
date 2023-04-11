var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var count = "";
console.log(typeof (count));
var c = /** @i */ (function () {
    function c(id, name) {
        this.id = this.setId(id);
        this.name = name;
    }
    c.prototype.get = function (w) {
        if (w === "num") {
            return this.id;
        }
        else {
            return this.name;
        }
    };
    c.prototype.setId = function (id) {
        return id;
    };
    c.prototype.setName = function (name) {
        return name;
    };
    return c;
}());
var d = /** @class */ (function (_super) {
    __extends(d, _super);
    function d(id, name) {
        return _super.call(this, id, name) || this;
    }
    return d;
}(c));
var cObj = new c(25, "Me");
var dObj = new d(5, "new me");
console.log(dObj.get("num"));
