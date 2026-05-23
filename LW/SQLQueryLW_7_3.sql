WITH PathCTE AS (
    SELECT 
        from_node, 
        to_node,
        CAST(CAST(from_node AS VARCHAR(10)) + ' -> ' + CAST(to_node AS VARCHAR(10)) AS VARCHAR(MAX)) AS full_path,
        CAST(',' + CAST(from_node AS VARCHAR(10)) + ',' + CAST(to_node AS VARCHAR(10)) + ',' AS VARCHAR(MAX)) AS path_string,

        CAST(distance_km AS NUMERIC(12,2)) AS total_distance,
        1 AS depth
    FROM routes
    WHERE from_node = 1
    
    UNION ALL

    SELECT 
        r.from_node, 
        r.to_node,
        CAST(p.full_path + ' -> ' + CAST(r.to_node AS VARCHAR(10)) AS VARCHAR(MAX)) AS full_path,
        CAST(p.path_string + CAST(r.to_node AS VARCHAR(10)) + ',' AS VARCHAR(MAX)) AS path_string,

        CAST(p.total_distance + r.distance_km AS NUMERIC(12,2)) AS total_distance,
        p.depth + 1
    FROM routes r
    INNER JOIN PathCTE p ON r.from_node = p.to_node
    WHERE p.depth < 5

      AND CHARINDEX(',' + CAST(r.to_node AS VARCHAR(10)) + ',', p.path_string) = 0
)
SELECT 
    full_path AS [Маршрут], 
    total_distance AS [Расстояние (км)]
FROM PathCTE
WHERE to_node = 5;