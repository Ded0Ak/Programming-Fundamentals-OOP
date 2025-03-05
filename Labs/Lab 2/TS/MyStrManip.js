"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.StringManipulator = void 0;
// StringManipulator.ts
var StringManipulator = /** @class */ (function () {
    // Constructor
    function StringManipulator(value) {
        if (value === void 0) { value = ""; }
        this.value = value;
    }
    // Method to get the string value
    StringManipulator.prototype.getValue = function () {
        return this.value;
    };
    // Method to get the string length
    StringManipulator.prototype.getLength = function () {
        return this.value.length;
    };
    // Method to sort the string in descending order
    StringManipulator.prototype.sortDescending = function () {
        return this.value.split("").sort().reverse().join("");
    };
    return StringManipulator;
}());
exports.StringManipulator = StringManipulator;
