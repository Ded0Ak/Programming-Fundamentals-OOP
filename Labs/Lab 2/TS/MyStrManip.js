"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.StringManipulator = void 0;
var StringManipulator = /** @class */ (function () {
    function StringManipulator(value) {
        if (value === void 0) { value = ""; }
        this.value = value;
    }
    StringManipulator.prototype.getValue = function () {
        return this.value;
    };
    StringManipulator.prototype.getLength = function () {
        return this.value.length;
    };
    StringManipulator.prototype.sortDescending = function () {
        return this.value.split("").sort().reverse().join("");
    };
    return StringManipulator;
}());
exports.StringManipulator = StringManipulator;
