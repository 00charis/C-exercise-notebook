## Syntax
*expression*. ``Curve``(``Arg1``, ``Arg2``, ``Arg3``, ``Arg4``)


## Parameters
| Name      | Required/Optional           | Data type  | Description|
| --------- |:-------------             | :-----    |:-----|
| Arg1      | Required                    | int        | Parent CurveUID
| Arg2      | Required                    | int        | Canlendar, which determins the datas count as good business days: <br /> -2 - All calendar dates, <br /> -1 - Using parent curve's holiday setting, <br /> >=0 - CalendarUID is defined in table enuit.SpecialCalendars.
| Arg3      | Required                    | int {1, 2,3, 4, 5}| Interpolation function: <br /> 1 - Backstep, <br /> 2 - Linear, <br /> 3 - Logarithm, <br /> 4 - CubicSpline, <br /> 5 - LinearRangeBeg.
| Arg3      | Required                    | int = 100 | CurveLookupTypeUID. To use this method, CurveLookupTypeUID should be 100.



## Remarks
* Use RangeBeginDate on child curve (this curve) to do lookup.
* Through RangeBeginDate on parent curve to do interpolation.
* Use flat extrapolation for all the five interpolation function supported.
