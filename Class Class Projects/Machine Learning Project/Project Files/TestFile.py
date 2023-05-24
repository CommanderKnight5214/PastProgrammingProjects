
# Code source: Jaques Grobler
# License: BSD 3 clause

import matplotlib.pyplot as plt
import pandas as pd  
import numpy as np  
import matplotlib.pyplot as plt  
import seaborn as seabornInstance 
from sklearn.model_selection import train_test_split 
from sklearn.linear_model import LinearRegression
from sklearn import datasets, linear_model
from sklearn.metrics import mean_squared_error, r2_score
from sklearn import metrics

def DataSetConversion (DataSet, temp):
    count = 0;
    for i in DataSet:
        tempInt = int(i);
        temp[count] = tempInt;
        print(count);
        count = count + 1;
    return temp
        
def TempArrayConversion (temp, DataSet):
    count = 0;
    for i in temp:
        DataSet[count] = i;
        count = count + 1;
    return DataSet
        
DataSet = pd.read_csv('/2021-2022 School Year 1st Semester/Machine Learning and Robotics/Machine Learning Project/Electric_Vehicle_Population_Data.csv'
                      ,usecols = [10,11], nrows = 78)
DataSetX = pd.read_csv('/2021-2022 School Year 1st Semester/Machine Learning and Robotics/Machine Learning Project/Electric_Vehicle_Population_Data.csv'
                      ,usecols = [10], nrows = 78)
DataSetY = pd.read_csv('/2021-2022 School Year 1st Semester/Machine Learning and Robotics/Machine Learning Project/Electric_Vehicle_Population_Data.csv'
                      ,usecols = [11], nrows = 78)

#print(DataSet);
#print(DataSetX);
#print(DataSetY);

#print(DataSet);
#print(DataSetX);
#print(DataSetY);

print(DataSet.shape)
print(DataSet.head)
print(DataSet.describe())

"""
DataSet.plot(x='Max Weight in tons', y='Electric Range', style='o')
plt.title('Max Weight in Tons vs Electric Range')
plt.xlabel('Max Weight in Tons')
plt.ylabel('Electric Range')
plt.show()

X = DataSet.iloc[:, :-1].values
y = DataSet.iloc[:, 1].values

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.3, random_state=0)

regressor = LinearRegression()
regressor.fit(X_train, y_train)

print(regressor.intercept_)

print(regressor.coef_)

y_pred = regressor.predict(X_test)

df = pd.DataFrame({'Actual': y_test, 'Predicted': y_pred})
print(df)

print('Mean Absolute Error:', metrics.mean_absolute_error(y_test, y_pred))
print('Mean Squared Error:', metrics.mean_squared_error(y_test, y_pred))
print('Root Mean Squared Error:', np.sqrt(metrics.mean_squared_error(y_test, y_pred)))

# Use only one feature
#DataSetX = DataSetX[:, np.newaxis, 2]
"""


# Split the data into training/testing sets
DataSetX_train = DataSetX[:-20]
DataSetX_test = DataSetX[-80:]

# Split the targets into training/testing sets
DataSetY_train = DataSetY[:-20]
DataSetY_test = DataSetY[-80:]

# Create linear regression object
regr = linear_model.LinearRegression()

# Train the model using the training sets
regr.fit(DataSetX_train, DataSetY_train)

# Make predictions using the testing set
DataSetY_pred = regr.predict(DataSetX_test)

# The coefficients
print('Coefficients: \n', regr.coef_)
# The mean squared error
print('Mean squared error: %.2f'
      % mean_squared_error(DataSetY_test, DataSetY_pred))
# The coefficient of determination: 1 is perfect prediction
print('Coefficient of determination: %.2f'
      % r2_score(DataSetY_test, DataSetY_pred))



plt.scatter(DataSetX_test, DataSetY_test,  color='black')
plt.plot(DataSetX_test, DataSetY_pred, color='green', linewidth=3)

plt.xticks(())
plt.yticks(())

plt.show()